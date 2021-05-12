using System.Collections.Generic;

namespace console_user_interface
{
    public interface ICommand
    {
        string Name { get; }
        string[] Usage { get; }

        void Execute(List<string> arguments, Data data);
    }
}