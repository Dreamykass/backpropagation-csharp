using System;
using System.Collections.Generic;
using System.Linq;

namespace console_user_interface.commands
{
    public class Rate : ICommand
    {
        public string Name { get; } = "rate";
        public string[] Usage { get; } = {"'rate <num>' - set the learning rate of the network to <num>"};
        public void Execute(List<string> arguments, Data data)
        {
            if (data.Network == null)
            {
                Console.WriteLine("Network is null.");
                return;
            }

            if (arguments.Count != 1)
            {
                Console.WriteLine("Not exactly 1 argument.");
                return;
            }

            if (!double.TryParse(arguments.First(), out _))
            {
                Console.WriteLine("Argument can't be parsed to double.");
                return;
            }

            data.Network.LearningRate = double.Parse(arguments.First());

        }
    }
}