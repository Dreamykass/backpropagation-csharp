using System.Collections.Generic;

namespace lib
{
    public class NeuronOutput : INeuron
    {
        public NeuronOutput(int id, int idInLayer, Layer<NeuronOutput> layer)
        {
            Id = id;
            IdInLayer = idInLayer;
            Layer = layer;
            IdOfLayer = Layer.Id;
        }

        public Layer<NeuronOutput> Layer { get; }
        public double ExpectedCurrent { get; private set; }
        public double ErrorCurrentNice { get; private set; } = 1;

        public int Id { get; }
        public int IdInLayer { get; }
        public int IdOfLayer { get; }
        public List<Connection> ConnectionsPrev { get; } = new();
        public List<Connection> ConnectionsNext { get; } = new();
        public double ValueCurrent { get; private set; }
        public double ErrorCurrent { get; private set; } = 1;
        public double ErrorPrevious { get; private set; } = 1;

        public void AddConnectionToPrev(Connection connection)
        {
            ConnectionsPrev.Add(connection);
        }

        public void AddConnectionToNext(Connection connection)
        {
            ConnectionsNext.Add(connection);
        }

        public void CalculateValueFromPrevious()
        {
            // page 70

            double value = 0;

            foreach (var connection in ConnectionsPrev)
                value += connection.Prev.ValueCurrent
                         * connection.WeightCurrent
                         + Layer.Bias;
            // Console.WriteLine("/"+value);
            value = Sigmoid.Activator(value);
            // Console.WriteLine(value);

            ValueCurrent = value;
        }

        public void CalculateErrorFromExpected(double expectedResult)
        {
            ExpectedCurrent = expectedResult;

            ErrorPrevious = ErrorCurrent;
            ErrorCurrent = (expectedResult - ValueCurrent) * Sigmoid.Derivative(ValueCurrent);

            ErrorCurrentNice = expectedResult - ValueCurrent;
        }
    }
}