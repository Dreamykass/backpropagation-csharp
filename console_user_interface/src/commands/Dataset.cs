using System;
using System.Collections.Generic;
using System.Linq;
using lib;

namespace console_user_interface.commands
{
    public class Dataset : ICommand
    {
        public string Name { get; } = "dataset";
        public string[] Usage { get; } = {"'dataset' - prints the loaded in dataset"};

        public void Execute(List<string> arguments, Data data)
        {
            if (data.NetworkInputs == null || data.NetworkExpectedOutputs == null)
                Console.WriteLine("No dataset loaded.");
            else
                foreach (var (inputs, outputs) in data.NetworkInputs.Zip(data.NetworkExpectedOutputs))
                    Console.WriteLine($"in: {Helpers.ArrayToString(inputs)}; \t " +
                                      $"out: {Helpers.ArrayToString(outputs)}");
        }
    }
}