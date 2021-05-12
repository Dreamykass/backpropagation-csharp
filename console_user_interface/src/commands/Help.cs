using System;
using System.Collections.Generic;

namespace console_user_interface.commands
{
    public class Help : ICommand
    {
        public string Name { get; } = "help";
        public string[] Usage { get; } = {"'help' - lists commands and their usages"};

        public void Execute(List<string> arguments, Data data)
        {
            Console.WriteLine("Listing possible commands:");

            foreach (var command in data.Commands.Values)
            {
                Console.WriteLine($"\n  {command.Name}; usage:");
                foreach (var line in command.Usage) Console.WriteLine($"      {line}");
            }
        }
    }
}