using System;
using System.Collections.Generic;

namespace console_user_interface.commands
{
    public class Layout : ICommand
    {
        public string Name { get; } = "layout";
        public string[] Usage { get; } = {"'layout' - prints the layout of the network, if initialized"};

        public void Execute(List<string> arguments, Data data)
        {
            if (data.Network == null)
                Console.WriteLine("Network is null.");
            else
                data.Network.PrintLayout();
        }
    }
}