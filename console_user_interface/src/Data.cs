using System.Collections.Generic;
using console_user_interface.commands;
using lib;

namespace console_user_interface
{
    public class Data
    {
        public Dictionary<string, ICommand> Commands = new();
        public Network Network = null;
        public List<double[]> NetworkExpectedOutputs = null;
        public List<double[]> NetworkInputs = null;


        public Data()
        {
            foreach (var command in new ICommand[]
            {
                new Clear(),
                new Dataset(),
                new Help(),
                new Init(),
                new Layout(),
                new Rate(),
                new Read(),
                new Test(),
                new Train()
            })
                Commands.Add(command.Name, command);
        }
    }
}