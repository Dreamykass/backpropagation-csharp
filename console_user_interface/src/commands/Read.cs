using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace console_user_interface.commands
{
    public class Read : ICommand
    {
        public string Name { get; } = "read";

        public string[] Usage { get; } =
        {
            "'read <filename>' - read dataset (inputs + outputs)",
            "should be space separated doubles, for example:",
            "'1.0 0.0 1.0', if the network layout has 2 inputs and 1 output (or 1 and 2)"
        };

        public void Execute(List<string> arguments, Data data)
        {
            if (data.Network == null)
            {
                Console.WriteLine("Network is null.");
                return;
            }

            var inputs = new List<double[]>();
            var outputs = new List<double[]>();
            var (inputCount, _, outputCount) = data.Network.GetNeuronCountsInLayers();

            try
            {
                foreach (var line in File.ReadLines(arguments.First()))
                {
                    var ns = line.Split(null);
                    var input = ns.Take(inputCount).Select(double.Parse).ToArray();
                    var output = ns.Skip(inputCount).Take(outputCount).Select(double.Parse).ToArray();
                    inputs.Add(input);
                    outputs.Add(output);
                }

                data.NetworkInputs = inputs;
                data.NetworkExpectedOutputs = outputs;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception string: ");
                Console.WriteLine(e.ToString());
                Console.WriteLine("\n\nException stack trace: ");
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}