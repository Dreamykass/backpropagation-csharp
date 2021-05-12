using System;
using System.Collections.Generic;
using lib;

namespace console_user_interface.commands
{
    public class Train : ICommand
    {
        public string Name { get; } = "train";

        public string[] Usage { get; } =
        {
            "'train' - trains on the dataset (previously 'read') until key press"
        };

        public void Execute(List<string> arguments, Data data)
        {
            if (data.Network == null)
            {
                Console.WriteLine("Network is null.");
                return;
            }

            Console.WriteLine("Press X to stop training.");

            var generation = 0;
            ConsoleKeyInfo cki;

            // do
            // {
            while (Console.KeyAvailable == false)
            {
                data.Network.TrainOnBatch(data.NetworkInputs, data.NetworkExpectedOutputs);
                generation++;

                if (generation % 1000 == 0)
                {
                    Console.Write($"current generation: \t {generation / 1000}k \t global err: ");
                    Helpers.ConsoleWriteError(data.Network.CurrentBatchErrorNice);
                }

                
                // Console.Write($"current generation: \t {generation} \t global err: ");
                // Helpers.ConsoleWriteError(data.Network.CurrentBatchErrorNice);
            }

            cki = Console.ReadKey(true);
            Console.WriteLine("You pressed the '{0}' key. Stopped training.", cki.Key);

            // } while (cki.Key != ConsoleKey.X);
        }
    }
}