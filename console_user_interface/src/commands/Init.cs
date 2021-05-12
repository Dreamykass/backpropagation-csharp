using System;
using System.Collections.Generic;
using System.Linq;
using lib;

namespace console_user_interface.commands
{
    public class Init : ICommand
    {
        public string Name { get; } = "init";

        public string[] Usage { get; } =
        {
            "init <in> <out> <hidden 1> <hidden 2> <hidden ...> <hidden n> ",
            " - initialize a new network with such neuron counts in layers"
        };

        public void Execute(List<string> arguments, Data data)
        {
            if (arguments.Count < 3)
            {
                Console.WriteLine("At least 3 or more arguments are needed for this command.");
                return;
            }

            if (arguments.Any(arg => !int.TryParse(arg, out _)))
            {
                Console.WriteLine("Arguments must be integers.");
                return;
            }

            var counts = arguments.Select(int.Parse).ToList();

            if (counts.Any(arg => arg < 1))
            {
                Console.WriteLine("Arguments need to be 1 or bigger.");
                return;
            }

            var neuronsIn = counts.First();
            var neuronsOut = counts.Skip(1).First();
            var neuronsHidden = counts.Skip(2).ToArray();

            data.Network = new Network(neuronsIn, neuronsHidden, neuronsOut);
        }
    }
}