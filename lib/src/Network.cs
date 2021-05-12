using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace lib
{
    public class Network
    {
        private readonly List<Connection> _connections = new();
        private readonly Layer<NeuronInput> _layerInput;
        private readonly Layer<NeuronOutput> _layerOutput;
        private readonly List<Layer<NeuronHidden>> _layersHidden = new();

        public Network(int inputNeuronsCount, IEnumerable<int> hiddenLayersCounts, int outputNeuronsCount)
        {
            var id = 0;
            var idLayer = 0;

            _layerInput = new Layer<NeuronInput>(idLayer);
            foreach (var idInLayer in Enumerable.Range(0, inputNeuronsCount))
            {
                _layerInput.Neurons.Add(new NeuronInput(id, idInLayer, _layerInput));
                id++;
            }

            idLayer++;

            foreach (var layers in hiddenLayersCounts)
            {
                var layerCurrent = new Layer<NeuronHidden>(idLayer);
                _layersHidden.Add(layerCurrent);

                foreach (var idInLayer in Enumerable.Range(0, layers))
                {
                    layerCurrent.Neurons.Add(new NeuronHidden(id, idInLayer, layerCurrent));
                    id++;
                }

                idLayer++;
            }

            _layerOutput = new Layer<NeuronOutput>(idLayer);
            foreach (var idInLayer in Enumerable.Range(0, outputNeuronsCount))
            {
                _layerOutput.Neurons.Add(new NeuronOutput(id, idInLayer, _layerOutput));
                id++;
            }

            ShapeConnections();
        }

        public double LearningRate { get; set; } = 0.1;
        public double Momentum { get; } = 0.1;
        public double CurrentGlobalError { get; private set; }
        public double PreviousGlobalError { get; private set; }
        public double CurrentGlobalErrorNice { get; private set; }
        public double CurrentBatchErrorNice { get; private set; }

        public (int, int[], int) GetNeuronCountsInLayers()
        {
            var hiddenCounts = new List<int>();
            _layersHidden.ForEach(layer => hiddenCounts.Add(layer.Neurons.Count));
            return (_layerInput.Neurons.Count, hiddenCounts.ToArray(), _layerOutput.Neurons.Count);
        }

        private void ShapeConnections()
        {
            var id = 0;

            {
                IEnumerable<INeuron>[] items =
                {
                    _layerInput.Neurons,
                    _layersHidden[0].Neurons
                };
                foreach (var p in Helpers.CartesianProduct(items))
                {
                    _connections.Add(new Connection(id, p.First(), p.ElementAt(1)));
                    id++;
                }
            }

            {
                foreach (var (layer1, layer2) in Helpers.SlidingWindow(_layersHidden))
                {
                    IEnumerable<INeuron>[] items =
                    {
                        layer1.Neurons,
                        layer2.Neurons
                    };
                    foreach (var p in Helpers.CartesianProduct(items))
                    {
                        _connections.Add(new Connection(id, p.First(), p.ElementAt(1)));
                        id++;
                    }
                }
            }

            {
                IEnumerable<INeuron>[] items =
                {
                    _layersHidden.Last().Neurons,
                    _layerOutput.Neurons
                };
                foreach (var p in Helpers.CartesianProduct(items))
                {
                    _connections.Add(new Connection(id, p.First(), p.ElementAt(1)));
                    id++;
                }
            }
        }

        public void PrintLayout()
        {
            Console.WriteLine("Printing the network.");
            Console.WriteLine("\nLearning rate: {0}", LearningRate);
            // Console.WriteLine("Momentum: {0}", Momentum);

            Console.WriteLine("\nInput neurons:");
            foreach (var n in _layerInput.Neurons)
                Console.WriteLine($"  ({n.Id}); layer: {n.IdOfLayer}; id in layer: {n.IdInLayer}");

            Console.WriteLine("\nHidden layers:");
            foreach (var l in _layersHidden)
            {
                Console.WriteLine("  Layer {0}:", l.Neurons[0].IdOfLayer);
                foreach (var n in l.Neurons)
                    Console.WriteLine($"    ({n.Id}); layer: {n.IdOfLayer}; id in layer: {n.IdInLayer}");
            }

            Console.WriteLine("\nOutput neurons:");
            foreach (var n in _layerOutput.Neurons)
                Console.WriteLine($"  ({n.Id}); layer: {n.IdOfLayer}; id in layer: {n.IdInLayer}");

            Console.WriteLine("\nConnections:");
            foreach (var c in _connections)
                Console.WriteLine($"  ({c.Id}); {c.Prev.Id} -> {c.Next.Id}; w: {c.WeightCurrent}");
            Console.WriteLine("\nDone.");
        }

        private double[] CollectOutput(double[] inputs)
        {
            Trace.Assert(inputs.Length == _layerInput.Neurons.Count);
            var outputs = new double[_layerOutput.Neurons.Count];

            foreach (var (inputNeuron, input) in _layerInput.Neurons.Zip(inputs)) inputNeuron.PassInputInside(input);

            _layersHidden.ForEach(layer => layer.Neurons.ForEach(neuron => neuron.CalculateValueFromPrevious()));

            _layerOutput.Neurons.ForEach(neuron =>
            {
                neuron.CalculateValueFromPrevious();
                outputs[neuron.IdInLayer] = neuron.ValueCurrent;
            });

            return outputs;
        }

        private void PropagateErrors(double[] expectedResults)
        {
            Trace.Assert(expectedResults.Length == _layerOutput.Neurons.Count);
            var outputErrors = new List<double>();
            var outputErrorsNice = new List<double>();

            // output layer
            // page 236
            foreach (var (expected, neuron) in expectedResults.Zip(_layerOutput.Neurons))
            {
                neuron.CalculateErrorFromExpected(expected);
                outputErrors.Add(neuron.ErrorCurrent);
                outputErrorsNice.Add(neuron.ErrorCurrentNice);
            }

            // hidden layers
            // page 132
            _layersHidden.Reverse();
            _layersHidden.ForEach(layer => { layer.Neurons.ForEach(neuron => { neuron.CalculateErrorFromNext(); }); });
            _layersHidden.Reverse();

            PreviousGlobalError = CurrentGlobalError;
            CurrentGlobalError = MeanSquare.RootMeanSquare(outputErrors);
            CurrentGlobalErrorNice = MeanSquare.RootMeanSquare(outputErrorsNice);
        }

        private void AdjustWeights(double[] expectedResults)
        {
            Trace.Assert(expectedResults.Length == _layerOutput.Neurons.Count);

            _connections.ForEach(connection =>
            {
                connection.AdjustWeight(LearningRate, Momentum, CurrentGlobalError);
            });
        }

        public void Epoch(double[] givenInputs, double[] expectedResults)
        {
            Trace.Assert(givenInputs.Length == _layerInput.Neurons.Count);
            Trace.Assert(expectedResults.Length == _layerOutput.Neurons.Count);

            CollectOutput(givenInputs);
            PropagateErrors(expectedResults);
            AdjustWeights(expectedResults);
        }

        public void TrainOnBatch(List<double[]> givenInputsList, List<double[]> expectedResultsList)
        {
            Trace.Assert(givenInputsList.Count == expectedResultsList.Count);

            CurrentBatchErrorNice = 0;

            for (var i = 0; i < givenInputsList.Count; i++)
            {
                Epoch(givenInputsList[i], expectedResultsList[i]);
                CurrentBatchErrorNice += CurrentGlobalErrorNice;
            }

            // CurrentBatchErrorNice = MeanSquare.RootMeanSquare()
            CurrentBatchErrorNice /= givenInputsList.Count;
        }

        public void TestAgainst(List<double[]> inputsList, List<double[]> resultsList, bool printAverageErrorOnly)
        {
            Trace.Assert(inputsList.Count == resultsList.Count);

            var averageError = 0.0;
            var correctlyCategorized = 0;

            for (var i = 0; i < inputsList.Count; i++)
            {
                var inputs = inputsList[i];
                var results = resultsList[i];

                Trace.Assert(inputs.Length == _layerInput.Neurons.Count);
                Trace.Assert(results.Length == _layerOutput.Neurons.Count);

                var finalPredicted = CollectOutput(inputs);
                PropagateErrors(results);

                if (!printAverageErrorOnly)
                {
                    // var s1 = string.Format(" in: {0};", Helpers.ArrayToString(inputs));
                    // var s2 = string.Format(" out: {0};", Helpers.ArrayToString(finalPredicted));
                    // var s3 = string.Format(" expected: {0};", Helpers.ArrayToString(results));
                    // var s4 = string.Format(" error: {0};", CurrentGlobalError);
                    //
                    // Console.WriteLine("{0}\t{1}\t{2}\t{3}", s1, s2, s3, s4);

                    var s1 = string.Format(" in: {0};", Helpers.ArrayToString(inputs));
                    var s2 = string.Format(" out: {0};", Helpers.ArrayToString(finalPredicted));
                    var s3 = string.Format(" expected: {0};", Helpers.ArrayToString(results));

                    Console.Write("{0}\t{1}\t{2}\t error: ", s1, s2, s3);
                    Helpers.ConsoleWriteError(CurrentGlobalErrorNice);
                }

                averageError += CurrentGlobalErrorNice;
                
                // check if correctly categorized
                {
                    var resultCategoryIndex = results.ToList().IndexOf(results.Max());
                    var predictedCategoryIndex = finalPredicted.ToList().IndexOf(finalPredicted.Max());

                    if (resultCategoryIndex == predictedCategoryIndex)
                        correctlyCategorized++;
                }
            }

            averageError /= inputsList.Count;

            Console.Write("Average error: ");
            Helpers.ConsoleWriteError(averageError);
            Console.WriteLine($"Correctly categorized: {correctlyCategorized}/{inputsList.Count}");
        }
    }
}