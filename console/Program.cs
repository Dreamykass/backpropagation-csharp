using System;
using System.Linq;

namespace console
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine("Hello World!");

            var (network, inputs, results) = Examples.Xor();
            // var (network, inputs, results) = Examples.Inversion();
            // var (network, inputs, results) = Examples.Addition();
            // var (network, inputs, results) = Examples.AdditionAndSubtraction();
            // var (network, inputs, results) = Examples.Sine();
            // var (network, inputs, results) = Examples.Shuttle();
            // var (network, inputs, results) = Examples.AirplaneType();
            // var (network, inputs, results) = Examples.AirplaneArmamentMain();
            // var (network, inputs, results) = Examples.AirplaneModelAndNation();

            Console.WriteLine("============================================");
            network.PrintLayout();

            Console.WriteLine("============================================");
            network.TestAgainst(inputs, results, false);
            Console.WriteLine("");

            Console.WriteLine("============================================");
            var epochsNum = 2000000000;
            foreach (var i in Enumerable.Range(0, epochsNum))
            {
                network.TrainOnBatch(inputs, results);

                if (i % 4000 != 0) continue;
                Console.WriteLine("============================================");
                Console.WriteLine("Epoch: {0}k/{1}k", i / 1000, epochsNum / 1000);
                network.TestAgainst(inputs, results, false);
            }

            Console.WriteLine("============================================");
            Console.WriteLine("============================================");
            network.TestAgainst(inputs, results, false);
            Console.WriteLine("");
        }


        // https://machinelearningmastery.com/implement-backpropagation-algorithm-scratch-python/
    }
}