using System;
using System.Collections.Generic;

namespace console_user_interface.commands
{
    public class Clear : ICommand
    {
        public string Name { get; } = "clear";
        public string[] Usage { get; } = {"'clear' - clears the screen"};

        public void Execute(List<string> arguments, Data data)
        {
            Console.Clear();
        }
    }
}