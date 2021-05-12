using System;
using System.Collections.Generic;

namespace console_user_interface.commands
{
    public class Test : ICommand
    {
        public string Name { get; } = "test";
        public string[] Usage { get; } = {"'test' - tests against the dataset (previously 'read')"};

        public void Execute(List<string> arguments, Data data)
        {
            if (data.Network == null)
            {
                Console.WriteLine("Network is null.");
                return;
            }

            data.Network.TestAgainst(data.NetworkInputs, data.NetworkExpectedOutputs, false);
        }
    }
}