using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace console_user_interface
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var data = new Data();

            Console.WriteLine("Hello in the program.");
            Console.WriteLine("Use 'help' for a list of possible commands.");

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("----------------------------");
                Console.WriteLine("Enter your command:");
                Console.Write(">");

                var consoleInput = Console.ReadLine();
                Trace.Assert(consoleInput != null);

                var consoleInputSplit = consoleInput.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var enteredCommand = consoleInputSplit[0];
                var enteredArguments = consoleInputSplit.Skip(1).ToList();

                var command = data.Commands.GetValueOrDefault(enteredCommand, null);
                Console.WriteLine();
                Console.WriteLine();

                if (command == null)
                    Console.WriteLine("...Invalid command. Use 'help' for a list of possible commands.");
                else
                    command.Execute(enteredArguments, data);
            }
        }
    }
}