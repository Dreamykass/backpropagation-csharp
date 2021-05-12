using System;
using System.Collections.Generic;
using lib;

namespace console
{
    public class Examples
    {
        public static (Network, List<double[]>, List<double[]>) Xor()
        {
            int[] hiddenLayers = {2};
            var network = new Network(2, hiddenLayers, 1);

            List<double[]> inputs = new();
            inputs.Add(new double[] {0, 0});
            inputs.Add(new double[] {0, 1});
            inputs.Add(new double[] {1, 0});
            inputs.Add(new double[] {1, 1});

            List<double[]> results = new();
            results.Add(new double[] {0});
            results.Add(new double[] {1});
            results.Add(new double[] {1});
            results.Add(new double[] {0});

            return (network, inputs, results);
        }

        public static (Network, List<double[]>, List<double[]>) Inversion()
        {
            int[] hiddenLayers = {2, 2};
            var network = new Network(2, hiddenLayers, 1);

            List<double[]> inputs = new();
            inputs.Add(new double[] {0, 0});
            inputs.Add(new[] {0.25, 0});
            inputs.Add(new[] {0.5, 0});
            inputs.Add(new[] {0.75, 0});
            inputs.Add(new double[] {1, 0});

            List<double[]> results = new();
            results.Add(new double[] {1});
            results.Add(new[] {0.75});
            results.Add(new[] {0.5});
            results.Add(new[] {0.25});
            results.Add(new double[] {0});

            return (network, inputs, results);
        }

        public static (Network, List<double[]>, List<double[]>) Addition()
        {
            int[] hiddenLayers = {2};
            var network = new Network(2, hiddenLayers, 1);

            List<double[]> inputs = new();
            List<double[]> results = new();
            inputs.Add(new[] {0.0, 0.0});
            results.Add(new[] {0.0});
            inputs.Add(new[] {0.1, 0.0});
            results.Add(new[] {0.1});
            inputs.Add(new[] {0.0, 0.1});
            results.Add(new[] {0.1});
            inputs.Add(new[] {0.1, 0.1});
            results.Add(new[] {0.2});

            inputs.Add(new[] {0.2, 0.0});
            results.Add(new[] {0.2});
            inputs.Add(new[] {0.0, 0.2});
            results.Add(new[] {0.2});
            inputs.Add(new[] {0.2, 0.2});
            results.Add(new[] {0.4});
            inputs.Add(new[] {0.1, 0.2});
            results.Add(new[] {0.3});
            inputs.Add(new[] {0.2, 0.1});
            results.Add(new[] {0.3});

            inputs.Add(new[] {0.7, 0.0});
            results.Add(new[] {0.7});
            inputs.Add(new[] {0.6, 0.0});
            results.Add(new[] {0.6});
            inputs.Add(new[] {0.6, 0.4});
            results.Add(new[] {1.0});
            inputs.Add(new[] {0.3, 0.4});
            results.Add(new[] {0.7});

            inputs.Add(new[] {0.1, 0.9});
            results.Add(new[] {1.0});
            inputs.Add(new[] {0.8, 0.2});
            results.Add(new[] {1.0});
            inputs.Add(new[] {0.1, 0.4});
            results.Add(new[] {0.5});
            inputs.Add(new[] {0.5, 0.2});
            results.Add(new[] {0.7});

            return (network, inputs, results);
        }

        public static (Network, List<double[]>, List<double[]>) AdditionAndSubtraction()
        {
            int[] hiddenLayers = {4};
            var network = new Network(4, hiddenLayers, 2);
            // out 1 = (in 1 + in 2); out 2 = (in 2 + in 4)

            List<double[]> inputs = new();
            List<double[]> results = new();
            inputs.Add(new[] {0.0, 0.0, 0.0, 0.0});
            results.Add(new[] {0.0, 0.0});
            inputs.Add(new[] {0.1, 0.0, 0.0, 0.0});
            results.Add(new[] {0.1, 0.0});
            inputs.Add(new[] {0.0, 0.1, 0.0, 0.0});
            results.Add(new[] {0.1, 0.0});
            inputs.Add(new[] {0.1, 0.1, 0.0, 0.0});
            results.Add(new[] {0.2, 0.0});

            inputs.Add(new[] {0.2, 0.0, 0.0, 0.0});
            results.Add(new[] {0.2, 0.0});
            inputs.Add(new[] {0.0, 0.2, 0.0, 0.0});
            results.Add(new[] {0.2, 0.0});
            inputs.Add(new[] {0.2, 0.2, 0.0, 0.0});
            results.Add(new[] {0.4, 0.0});
            inputs.Add(new[] {0.1, 0.2, 0.0, 0.0});
            results.Add(new[] {0.3, 0.0});
            inputs.Add(new[] {0.2, 0.1, 0.0, 0.0});
            results.Add(new[] {0.3, 0.0});

            inputs.Add(new[] {0.7, 0.0, 0.0, 0.0});
            results.Add(new[] {0.7, 0.0});
            inputs.Add(new[] {0.6, 0.0, 0.0, 0.0});
            results.Add(new[] {0.6, 0.0});
            inputs.Add(new[] {0.6, 0.4, 0.0, 0.0});
            results.Add(new[] {1.0, 0.0});
            inputs.Add(new[] {0.3, 0.4, 0.0, 0.0});
            results.Add(new[] {0.7, 0.0});

            inputs.Add(new[] {0.1, 0.9, 0.0, 0.0});
            results.Add(new[] {1.0, 0.0});
            inputs.Add(new[] {0.8, 0.2, 0.0, 0.0});
            results.Add(new[] {1.0, 0.0});
            inputs.Add(new[] {0.1, 0.4, 0.0, 0.0});
            results.Add(new[] {0.5, 0.0});
            inputs.Add(new[] {0.5, 0.2, 0.0, 0.0});
            results.Add(new[] {0.7, 0.0});

            inputs.Add(new[] {0.2, 0.0, 0.0, 0.1});
            results.Add(new[] {0.1, 0.1});
            inputs.Add(new[] {0.0, 0.2, 0.0, 0.2});
            results.Add(new[] {0.0, 0.4});
            inputs.Add(new[] {0.2, 0.2, 0.0, 0.1});
            results.Add(new[] {0.3, 0.3});
            inputs.Add(new[] {0.2, 0.2, 0.0, 0.2});
            results.Add(new[] {0.2, 0.4});
            inputs.Add(new[] {0.1, 0.2, 0.0, 0.1});
            results.Add(new[] {0.2, 0.3});
            inputs.Add(new[] {0.2, 0.1, 0.0, 0.3});
            results.Add(new[] {0.0, 0.4});

            return (network, inputs, results);
        }

        public static (Network, List<double[]>, List<double[]>) Sine()
        {
            int[] hiddenLayers = {2};
            var network = new Network(1, hiddenLayers, 1);

            List<double[]> inputs = new();
            List<double[]> results = new();
            for (var i = 0.0; i < 1.0; i += 0.04)
            {
                inputs.Add(new[] {i});
                results.Add(new[] {Math.Sin(i)});
            }

            return (network, inputs, results);
        }

        public static (Network, List<double[]>, List<double[]>) Shuttle()
        {
            // http://neuroph.sourceforge.net/tutorials/ShuttleLandingControl/ShuttleLandingControl.htm
            // http://neuroph.sourceforge.net/tutorials/ShuttleLandingControl/download/parametri.txt

            int[] hiddenLayers = {8, 5, 3};
            var network = new Network(6, hiddenLayers, 2);

            List<double[]> inputs = new();
            List<double[]> results = new();

            inputs.Add(new[] {0.25, 0.25, 0.25, 0.25, 0.25, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 0.25, 0.25, 0.25, 0.5, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 0.25, 0.25, 0.25, 0.75, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 0.25, 0.25, 0.25, 1, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 0.25, 0.25, 0.5, 0.25, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 0.25, 0.25, 0.5, 0.5, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 0.25, 0.25, 0.5, 0.75, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 0.25, 0.25, 0.5, 1, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 0.25, 0.5, 0.25, 0.25, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 0.25, 0.5, 0.25, 0.5, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 0.25, 0.5, 0.25, 0.75, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 0.25, 0.5, 0.25, 1, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 0.25, 0.5, 0.5, 0.25, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 0.25, 0.5, 0.5, 0.5, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 0.25, 0.5, 0.5, 0.75, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 0.25, 0.5, 0.5, 1, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 0.5, 0.25, 0.25, 0.25, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 0.5, 0.25, 0.25, 0.5, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 0.5, 0.25, 0.25, 0.75, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 0.5, 0.25, 0.25, 1, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 0.5, 0.25, 0.5, 0.25, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 0.5, 0.25, 0.5, 0.5, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 0.5, 0.25, 0.5, 0.75, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 0.5, 0.25, 0.5, 1, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 0.5, 0.5, 0.25, 0.25, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 0.5, 0.5, 0.25, 0.5, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 0.5, 0.5, 0.25, 0.75, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 0.5, 0.5, 0.25, 1, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 0.5, 0.5, 0.5, 0.25, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 0.5, 0.5, 0.5, 0.5, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 0.5, 0.5, 0.5, 0.75, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 0.5, 0.5, 0.5, 1, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 0.75, 0.25, 0.25, 0.25, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 0.75, 0.25, 0.25, 0.5, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 0.75, 0.25, 0.25, 0.75, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 0.75, 0.25, 0.25, 1, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 0.75, 0.25, 0.5, 0.25, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 0.75, 0.25, 0.5, 0.5, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 0.75, 0.25, 0.5, 0.75, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 0.75, 0.25, 0.5, 1, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 0.75, 0.5, 0.25, 0.25, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 0.75, 0.5, 0.25, 0.5, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 0.75, 0.5, 0.25, 0.75, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 0.75, 0.5, 0.25, 1, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 0.75, 0.5, 0.5, 0.25, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 0.75, 0.5, 0.5, 0.5, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 0.75, 0.5, 0.5, 0.75, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 0.75, 0.5, 0.5, 1, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 1, 0.25, 0.25, 0.25, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 1, 0.25, 0.25, 0.5, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 1, 0.25, 0.25, 0.75, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 1, 0.25, 0.25, 1, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 1, 0.25, 0.5, 0.25, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 1, 0.25, 0.5, 0.5, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 1, 0.25, 0.5, 0.75, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 1, 0.25, 0.5, 1, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 1, 0.5, 0.25, 0.25, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 1, 0.5, 0.25, 0.5, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 1, 0.5, 0.25, 0.75, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 1, 0.5, 0.25, 1, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 1, 0.5, 0.5, 0.25, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 1, 0.5, 0.5, 0.5, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 1, 0.5, 0.5, 0.75, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 1, 0.5, 0.5, 1, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 0.25, 0.25, 0.25, 0.25, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 0.25, 0.25, 0.25, 0.5, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 0.25, 0.25, 0.25, 0.75, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 0.25, 0.25, 0.25, 1, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 0.25, 0.25, 0.5, 0.25, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 0.25, 0.25, 0.5, 0.5, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 0.25, 0.25, 0.5, 0.75, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 0.25, 0.25, 0.5, 1, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 0.25, 0.5, 0.25, 0.25, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 0.25, 0.5, 0.25, 0.5, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 0.25, 0.5, 0.25, 0.75, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 0.25, 0.5, 0.25, 1, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 0.25, 0.5, 0.5, 0.25, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 0.25, 0.5, 0.5, 0.5, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 0.25, 0.5, 0.5, 0.75, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 0.25, 0.5, 0.5, 1, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 0.5, 0.25, 0.25, 0.25, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 0.5, 0.25, 0.25, 0.5, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 0.5, 0.25, 0.25, 0.75, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 0.5, 0.25, 0.25, 1, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 0.5, 0.25, 0.5, 0.25, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 0.5, 0.25, 0.5, 0.5, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 0.5, 0.25, 0.5, 0.75, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 0.5, 0.25, 0.5, 1, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 0.5, 0.5, 0.25, 0.25, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 0.5, 0.5, 0.25, 0.5, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 0.5, 0.5, 0.25, 0.75, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 0.5, 0.5, 0.25, 1, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 0.5, 0.5, 0.5, 0.25, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 0.5, 0.5, 0.5, 0.5, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 0.5, 0.5, 0.5, 0.75, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 0.5, 0.5, 0.5, 1, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 0.75, 0.25, 0.25, 0.25, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 0.75, 0.25, 0.25, 0.5, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 0.75, 0.25, 0.25, 0.75, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 0.75, 0.25, 0.25, 1, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 0.75, 0.25, 0.5, 0.25, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 0.75, 0.25, 0.5, 0.5, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 0.75, 0.25, 0.5, 0.75, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 0.75, 0.25, 0.5, 1, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 0.75, 0.5, 0.25, 0.25, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 0.75, 0.5, 0.25, 0.5, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 0.75, 0.5, 0.25, 0.75, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 0.75, 0.5, 0.25, 1, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 0.75, 0.5, 0.5, 0.25, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 0.75, 0.5, 0.5, 0.5, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 0.75, 0.5, 0.5, 0.75, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 0.75, 0.5, 0.5, 1, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 1, 0.25, 0.25, 0.25, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 1, 0.25, 0.25, 0.5, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 1, 0.25, 0.25, 0.75, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 1, 0.25, 0.25, 1, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 1, 0.25, 0.5, 0.25, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 1, 0.25, 0.5, 0.5, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 1, 0.25, 0.5, 0.75, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 1, 0.25, 0.5, 1, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 1, 0.5, 0.25, 0.25, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 1, 0.5, 0.25, 0.5, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 1, 0.5, 0.25, 0.75, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 1, 0.5, 0.25, 1, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 1, 0.5, 0.5, 0.25, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 1, 0.5, 0.5, 0.5, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 1, 0.5, 0.5, 0.75, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 1, 0.5, 0.5, 1, 0.5});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.5, 0.25, 0.25, 0.25, 0.25, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.25, 0.25, 0.25, 0.5, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.25, 0.25, 0.25, 0.75, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.25, 0.25, 0.25, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.25, 0.25, 0.5, 0.25, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.25, 0.25, 0.5, 0.5, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.25, 0.25, 0.5, 0.75, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.25, 0.25, 0.5, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.25, 0.5, 0.25, 0.25, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.25, 0.5, 0.25, 0.5, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.25, 0.5, 0.25, 0.75, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.25, 0.5, 0.25, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.25, 0.5, 0.5, 0.25, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.25, 0.5, 0.5, 0.5, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.25, 0.5, 0.5, 0.75, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.25, 0.5, 0.5, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.5, 0.25, 0.25, 0.25, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.5, 0.25, 0.25, 0.5, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.5, 0.25, 0.25, 0.75, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.5, 0.25, 0.25, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.5, 0.25, 0.5, 0.25, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.5, 0.25, 0.5, 0.5, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.5, 0.25, 0.5, 0.75, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.5, 0.25, 0.5, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.5, 0.5, 0.25, 0.25, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.5, 0.5, 0.25, 0.5, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.5, 0.5, 0.25, 0.75, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.5, 0.5, 0.25, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.5, 0.5, 0.5, 0.25, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.5, 0.5, 0.5, 0.5, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.5, 0.5, 0.5, 0.75, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.5, 0.5, 0.5, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.75, 0.25, 0.25, 0.25, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.75, 0.25, 0.25, 0.5, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.75, 0.25, 0.25, 0.75, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.75, 0.25, 0.25, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.75, 0.25, 0.5, 0.25, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.75, 0.25, 0.5, 0.5, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.75, 0.25, 0.5, 0.75, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.75, 0.25, 0.5, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.75, 0.5, 0.25, 0.25, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.75, 0.5, 0.25, 0.5, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.75, 0.5, 0.25, 0.75, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.75, 0.5, 0.25, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.75, 0.5, 0.5, 0.25, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.75, 0.5, 0.5, 0.5, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.75, 0.5, 0.5, 0.75, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.75, 0.5, 0.5, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 1, 0.25, 0.25, 0.25, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 1, 0.25, 0.25, 0.5, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 1, 0.25, 0.25, 0.75, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 1, 0.25, 0.25, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 1, 0.25, 0.5, 0.25, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 1, 0.25, 0.5, 0.5, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 1, 0.25, 0.5, 0.75, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 1, 0.25, 0.5, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 1, 0.5, 0.25, 0.25, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 1, 0.5, 0.25, 0.5, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 1, 0.5, 0.25, 0.75, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 1, 0.5, 0.25, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 1, 0.5, 0.5, 0.25, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 1, 0.5, 0.5, 0.5, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 1, 0.5, 0.5, 0.75, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 1, 0.5, 0.5, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.25, 0.5, 0.25, 0.25, 0.25, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.25, 0.5, 0.25, 0.25, 0.5, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.25, 0.5, 0.25, 0.25, 0.75, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.25, 0.5, 0.25, 0.25, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.25, 0.5, 0.25, 0.5, 0.25, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.25, 0.5, 0.25, 0.5, 0.5, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.25, 0.5, 0.25, 0.5, 0.75, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.25, 0.5, 0.25, 0.5, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.25, 0.5, 0.5, 0.25, 0.25, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.25, 0.5, 0.5, 0.25, 0.5, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.25, 0.5, 0.5, 0.25, 0.75, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.25, 0.5, 0.5, 0.25, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.25, 0.5, 0.5, 0.5, 0.25, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.25, 0.5, 0.5, 0.5, 0.5, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.25, 0.5, 0.5, 0.5, 0.75, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.25, 0.5, 0.5, 0.5, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.25, 0.25, 0.25, 0.25, 0.25, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.25, 0.25, 0.25, 0.25, 0.5, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.25, 0.25, 0.25, 0.25, 0.75, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.25, 0.25, 0.25, 0.25, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.25, 0.25, 0.25, 0.5, 0.25, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.25, 0.25, 0.25, 0.5, 0.5, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.25, 0.25, 0.25, 0.5, 0.75, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.25, 0.25, 0.25, 0.5, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.25, 0.25, 0.5, 0.25, 0.25, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.25, 0.25, 0.5, 0.25, 0.5, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.25, 0.25, 0.5, 0.25, 0.75, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.25, 0.25, 0.5, 0.25, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.25, 0.25, 0.5, 0.5, 0.25, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.25, 0.25, 0.5, 0.5, 0.5, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.25, 0.25, 0.5, 0.5, 0.75, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.25, 0.25, 0.5, 0.5, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.25, 0.75, 0.5, 0.5, 0.25, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.25, 0.75, 0.5, 0.5, 0.5, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.25, 0.75, 0.5, 0.5, 0.75, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.25, 0.75, 0.5, 0.5, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.25, 0.25, 0.25, 0.25, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.25, 0.25, 0.25, 0.5, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.25, 0.25, 0.5, 0.25, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.25, 0.25, 0.5, 0.5, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.25, 0.5, 0.25, 0.25, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.25, 0.5, 0.25, 0.5, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.25, 0.5, 0.5, 0.25, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.25, 0.5, 0.5, 0.5, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.25, 0.75, 0.25, 0.25, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.25, 0.75, 0.25, 0.5, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.25, 0.75, 0.5, 0.25, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.25, 0.75, 0.5, 0.5, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.25, 1, 0.25, 0.25, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.25, 1, 0.25, 0.5, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.25, 1, 0.5, 0.25, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.25, 1, 0.5, 0.5, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.25, 0.25, 0.25, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.25, 0.25, 0.5, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.25, 0.5, 0.25, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.25, 0.5, 0.5, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.5, 0.25, 0.25, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.5, 0.25, 0.5, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.5, 0.5, 0.25, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.5, 0.5, 0.5, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.75, 0.25, 0.25, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.75, 0.25, 0.5, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.75, 0.5, 0.25, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 0.75, 0.5, 0.5, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 1, 0.25, 0.25, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 1, 0.25, 0.5, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 1, 0.5, 0.25, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.5, 1, 0.5, 0.5, 1, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.25, 1, 0.25, 0.25, 0.25, 0.25});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 1, 0.25, 0.5, 0.25, 0.25});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 1, 0.5, 0.25, 0.25, 0.25});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 1, 0.5, 0.5, 0.25, 0.25});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 1, 0.25, 0.25, 0.5, 0.25});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 1, 0.25, 0.5, 0.5, 0.25});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 1, 0.5, 0.25, 0.5, 0.25});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 1, 0.5, 0.5, 0.5, 0.25});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 1, 0.25, 0.25, 0.75, 0.25});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 1, 0.25, 0.5, 0.75, 0.25});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 1, 0.5, 0.25, 0.75, 0.25});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 1, 0.5, 0.5, 0.75, 0.25});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 0.75, 0.25, 0.25, 0.25, 0.25});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 0.75, 0.25, 0.25, 0.5, 0.25});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 0.75, 0.25, 0.5, 0.25, 0.25});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 0.75, 0.25, 0.5, 0.5, 0.25});
            results.Add(new double[] {0, 1});
            inputs.Add(new[] {0.25, 0.75, 0.25, 0.25, 0.75, 0.25});
            results.Add(new double[] {1, 0});
            inputs.Add(new[] {0.25, 0.75, 0.25, 0.5, 0.75, 0.25});
            results.Add(new double[] {0, 1});


            return (network, inputs, results);
        }

        public static (Network, List<double[]>, List<double[]>) AirplaneType()
        {
            int[] hiddenLayers = {5, 4, 3};
            var network = new Network(6, hiddenLayers, 3);

            List<double[]> inputs = new();
            List<double[]> results = new();

            inputs.Add(new[] {1, 0, 0, 0, 1, 0.0221606648199446});
            results.Add(new double[] {1, 0, 0});
            inputs.Add(new[] {1, 0, 0, 0, 1, 0.0249307479224377});
            results.Add(new double[] {1, 0, 0});
            inputs.Add(new[] {1, 0, 0, 0, 1, 0.0110803324099723});
            results.Add(new double[] {1, 0, 0});
            inputs.Add(new[] {1, 0, 0, 0, 1, 0.316712834718375});
            results.Add(new double[] {1, 0, 0});
            inputs.Add(new double[] {0, 1, 0, 0, 0, 0});
            results.Add(new double[] {0, 1, 0});
            inputs.Add(new[] {0, 1, 0, 0, 0, 0.00646352723915051});
            results.Add(new double[] {0, 1, 0});
            inputs.Add(new[] {1, 0, 0, 0, 1, 0.261311172668513});
            results.Add(new double[] {1, 0, 0});
            inputs.Add(new[] {1, 0, 0, 0, 1, 0.570637119113573});
            results.Add(new double[] {1, 0, 0});
            inputs.Add(new[] {1, 0, 0, 0, 1, 0.12280701754386});
            results.Add(new double[] {1, 0, 0});
            inputs.Add(new[] {1, 0, 0, 0, 0, 0.0729455216989843});
            results.Add(new double[] {1, 0, 0});
            inputs.Add(new[] {1, 0, 0, 0, 1, 0.178208679593721});
            results.Add(new double[] {1, 0, 0});
            inputs.Add(new[] {1, 0, 0, 0, 1, 0.132040627885503});
            results.Add(new double[] {1, 0, 0});
            inputs.Add(new[] {0, 0, 1, 0, 1, 0.0535549399815328});
            results.Add(new double[] {1, 0, 0});
            inputs.Add(new[] {0, 0, 1, 0, 1, 0.0572483841181902});
            results.Add(new double[] {1, 0, 0});
            inputs.Add(new[] {0, 1, 0, 0, 0, 0.048938134810711});
            results.Add(new double[] {0, 1, 0});
            inputs.Add(new[] {0, 1, 0, 0, 0, 0.0517082179132041});
            results.Add(new double[] {0, 1, 0});
            inputs.Add(new[] {0, 1, 0, 0, 0, 0.0166204986149584});
            results.Add(new double[] {0, 1, 0});
            inputs.Add(new[] {0, 1, 0, 0, 0, 0.0120036934441367});
            results.Add(new double[] {0, 1, 0});
            inputs.Add(new[] {0, 1, 0, 0, 0, 0.0304709141274238});
            results.Add(new double[] {0, 1, 0});
            inputs.Add(new[] {0, 0, 0, 1, 0, 0.0397045244690674});
            results.Add(new double[] {0, 1, 0});
            inputs.Add(new[] {0, 0, 0, 1, 0, 0.0581717451523546});
            results.Add(new double[] {0, 1, 0});
            inputs.Add(new[] {0, 0, 0, 1, 1, 0.153277931671283});
            results.Add(new double[] {0, 0, 1});
            inputs.Add(new[] {0, 0, 0, 1, 1, 0.153277931671283});
            results.Add(new double[] {0, 0, 1});
            inputs.Add(new[] {1, 0, 0, 0, 1, 0.0120036934441367});
            results.Add(new double[] {1, 0, 0});
            inputs.Add(new[] {0, 1, 0, 0, 0, 0.00923361034164358});
            results.Add(new double[] {0, 1, 0});
            inputs.Add(new[] {0, 0, 0, 1, 0, 0.0166204986149584});
            results.Add(new double[] {0, 1, 0});
            inputs.Add(new[] {0, 0, 0, 1, 0, 0.0138504155124654});
            results.Add(new double[] {0, 1, 0});
            inputs.Add(new[] {0, 0, 0, 1, 1, 0.0480147737765466});
            results.Add(new double[] {0, 1, 0});
            inputs.Add(new double[] {0, 0, 0, 1, 1, 1});
            results.Add(new double[] {1, 0, 0});
            inputs.Add(new[] {0, 1, 0, 0, 1, 0.048938134810711});
            results.Add(new double[] {1, 0, 0});
            inputs.Add(new[] {0, 0, 0, 1, 1, 0.136657433056325});
            results.Add(new double[] {0, 1, 0});
            inputs.Add(new[] {0, 0, 0, 1, 0, 0.07202216066482});
            results.Add(new double[] {0, 1, 0});
            inputs.Add(new[] {0, 1, 0, 0, 1, 0.0240073868882733});
            results.Add(new double[] {1, 0, 0});
            inputs.Add(new[] {0, 0, 0, 1, 0, 0.0397045244690674});
            results.Add(new double[] {0, 1, 0});
            inputs.Add(new[] {0, 1, 0, 0, 1, 0.193905817174515});
            results.Add(new double[] {1, 0, 0});


            return (network, inputs, results);
        }

        public static (Network, List<double[]>, List<double[]>) AirplaneArmamentMain()
        {
            int[] hiddenLayers = {5, 4};
            var network = new Network(3, hiddenLayers, 4);

            List<double[]> inputs = new();
            List<double[]> results = new();

            inputs.Add(new[] {0.236279192288874, 0.532786885245902, 0.0724137931034483});
            results.Add(new double[] {1, 0, 0, 0});
            inputs.Add(new[] {0.24128719758534, 0.663934426229508, 0.344827586206897});
            results.Add(new double[] {1, 0, 0, 0});
            inputs.Add(new[] {0.214995169778892, 0.614754098360656, 0.137931034482759});
            results.Add(new double[] {1, 0, 0, 0});
            inputs.Add(new[] {0, 0.770491803278688, 0.301724137931034});
            results.Add(new double[] {1, 0, 0, 0});
            inputs.Add(new[] {0.136369486624369, 0.663934426229508, 0.410344827586207});
            results.Add(new double[] {0, 1, 0, 0});
            inputs.Add(new[] {0.236279192288874, 0.704918032786885, 0.586206896551724});
            results.Add(new double[] {0, 1, 0, 0});
            inputs.Add(new[] {1, 0.352459016393443, 0.310344827586207});
            results.Add(new double[] {1, 0, 0, 0});
            inputs.Add(new[] {0.549279523318024, 0.844262295081967, 0.482758620689655});
            results.Add(new double[] {1, 0, 0, 0});
            inputs.Add(new[] {0.399039364424032, 0.680327868852459, 0.310344827586207});
            results.Add(new double[] {1, 0, 0, 0});
            inputs.Add(new[] {0.49919947035336, 0.188524590163934, 0.310344827586207});
            results.Add(new double[] {1, 0, 0, 0});
            inputs.Add(new[] {0.3739993379417, 0.229508196721311, 0.0172413793103448});
            results.Add(new double[] {1, 0, 0, 0});
            inputs.Add(new[] {0.49919947035336, 0.188524590163934, 0.310344827586207});
            results.Add(new double[] {1, 0, 0, 0});
            inputs.Add(new[] {0.348959311459368, 0.319672131147541, 0.189655172413793});
            results.Add(new double[] {0, 0, 1, 0});
            inputs.Add(new[] {0.3739993379417, 0, 0.137931034482759});
            results.Add(new double[] {0, 0, 1, 0});
            inputs.Add(new[] {0.348959311459368, 0.352459016393443, 1});
            results.Add(new double[] {0, 1, 0, 0});
            inputs.Add(new[] {0.3739993379417, 0.762295081967213, 0.482758620689655});
            results.Add(new double[] {0, 1, 0, 0});
            inputs.Add(new[] {0.273839232012372, 0.155737704918033, 0.362068965517241});
            results.Add(new double[] {0, 1, 0, 0});
            inputs.Add(new[] {0.298879258494704, 0.434426229508197, 0.482758620689655});
            results.Add(new double[] {0, 1, 0, 0});
            inputs.Add(new[] {0.298879258494704, 0.10655737704918, 0.655172413793103});
            results.Add(new double[] {0, 1, 0, 0});
            inputs.Add(new[] {0.574319549800356, 0.270491803278688, 0.482758620689655});
            results.Add(new double[] {0, 0, 0, 1});
            inputs.Add(new[] {0.24879920553004, 0.10655737704918, 0.568965517241379});
            results.Add(new double[] {0, 0, 0, 1});
            inputs.Add(new[] {0.49919947035336, 0.352459016393443, 0.310344827586207});
            results.Add(new double[] {0, 0, 0, 1});
            inputs.Add(new[] {0.549279523318024, 0.270491803278688, 0.482758620689655});
            results.Add(new double[] {0, 0, 0, 1});
            inputs.Add(new[] {0.24128719758534, 0.352459016393443, 0});
            results.Add(new double[] {1, 0, 0, 0});
            inputs.Add(new[] {0.166167118138344, 0.598360655737705, 0.25});
            results.Add(new double[] {0, 1, 0, 0});
            inputs.Add(new[] {0.31515527570822, 0.885245901639344, 0.641379310344828});
            results.Add(new double[] {0, 0, 0, 1});
            inputs.Add(new[] {0.318911279680569, 0.680327868852459, 0.648275862068965});
            results.Add(new double[] {0, 0, 0, 1});
            inputs.Add(new[] {0.261319218771206, 0.680327868852459, 0.387931034482759});
            results.Add(new double[] {0, 0, 0, 1});
            inputs.Add(new[] {0.3739993379417, 0.598360655737705, 0.172413793103448});
            results.Add(new double[] {0, 0, 0, 1});
            inputs.Add(new[] {0.144883095628362, 0.557377049180328, 0.0637931034482759});
            results.Add(new double[] {0, 1, 0, 0});
            inputs.Add(new[] {0.649439629247352, 0.516393442622951, 0.258620689655172});
            results.Add(new double[] {0, 0, 0, 1});
            inputs.Add(new[] {0.353967316755834, 0.762295081967213, 0.78448275862069});
            results.Add(new double[] {0, 0, 0, 1});
            inputs.Add(new[] {0.191207144620676, 0.516393442622951, 0.0672413793103448});
            results.Add(new double[] {0, 1, 0, 0});
            inputs.Add(new[] {0.198719152565376, 1, 0.629310344827586});
            results.Add(new double[] {0, 0, 0, 1});
            inputs.Add(new[] {0.212991967660305, 0.352459016393443, 0.1});
            results.Add(new double[] {0, 1, 0, 0});


            return (network, inputs, results);
        }

        public static (Network, List<double[]>, List<double[]>) AirplaneNation()
        {
            int[] hiddenLayers = {8, 7, 4};
            var network = new Network(10, hiddenLayers, 3);

            List<double[]> inputs = new();
            List<double[]> results = new();

            inputs.Add(new[] {1, 1, 0, 0, 0, 1, 0, 0, 0.0724137931034483, 0.0221606648199446});
            results.Add(new double[] {1, 0, 0});
            inputs.Add(new[] {1, 1, 0, 0, 0, 1, 0, 0, 0.344827586206897, 0.0249307479224377});
            results.Add(new double[] {1, 0, 0});
            inputs.Add(new[] {0, 1, 0, 0, 0, 1, 0, 0, 0.137931034482759, 0.0110803324099723});
            results.Add(new double[] {1, 0, 0});
            inputs.Add(new[] {0, 1, 0, 0, 0, 1, 0, 0, 0.301724137931034, 0.316712834718375});
            results.Add(new double[] {1, 0, 0});
            inputs.Add(new[] {1, 0, 1, 0, 0, 0, 1, 0, 0.410344827586207, 0});
            results.Add(new double[] {1, 0, 0});
            inputs.Add(new[] {1, 0, 1, 0, 0, 0, 1, 0, 0.586206896551724, 0.00646352723915051});
            results.Add(new double[] {1, 0, 0});
            inputs.Add(new[] {0, 1, 0, 0, 0, 1, 0, 0, 0.310344827586207, 0.261311172668513});
            results.Add(new double[] {0, 1, 0});
            inputs.Add(new[] {0, 1, 0, 0, 0, 1, 0, 0, 0.482758620689655, 0.570637119113573});
            results.Add(new double[] {0, 1, 0});
            inputs.Add(new[] {0, 1, 0, 0, 0, 1, 0, 0, 0.310344827586207, 0.12280701754386});
            results.Add(new double[] {0, 1, 0});
            inputs.Add(new[] {1, 1, 0, 0, 0, 1, 0, 0, 0.310344827586207, 0.0729455216989843});
            results.Add(new double[] {0, 1, 0});
            inputs.Add(new[] {0, 1, 0, 0, 0, 1, 0, 0, 0.0172413793103448, 0.178208679593721});
            results.Add(new double[] {0, 1, 0});
            inputs.Add(new[] {0, 1, 0, 0, 0, 1, 0, 0, 0.310344827586207, 0.132040627885503});
            results.Add(new double[] {0, 1, 0});
            inputs.Add(new[] {1, 0, 0, 1, 0, 1, 0, 0, 0.189655172413793, 0.0535549399815328});
            results.Add(new double[] {0, 1, 0});
            inputs.Add(new[] {1, 0, 0, 1, 0, 1, 0, 0, 0.137931034482759, 0.0572483841181902});
            results.Add(new double[] {0, 1, 0});
            inputs.Add(new[] {0, 0, 1, 0, 0, 0, 1, 0, 1, 0.048938134810711});
            results.Add(new double[] {0, 1, 0});
            inputs.Add(new[] {1, 0, 1, 0, 0, 0, 1, 0, 0.482758620689655, 0.0517082179132041});
            results.Add(new double[] {0, 1, 0});
            inputs.Add(new[] {0, 0, 1, 0, 0, 0, 1, 0, 0.362068965517241, 0.0166204986149584});
            results.Add(new double[] {0, 1, 0});
            inputs.Add(new[] {0, 0, 1, 0, 0, 0, 1, 0, 0.482758620689655, 0.0120036934441367});
            results.Add(new double[] {0, 1, 0});
            inputs.Add(new[] {0, 0, 1, 0, 0, 0, 1, 0, 0.655172413793103, 0.0304709141274238});
            results.Add(new double[] {0, 1, 0});
            inputs.Add(new[] {0, 0, 0, 0, 1, 0, 1, 0, 0.482758620689655, 0.0397045244690674});
            results.Add(new double[] {0, 1, 0});
            inputs.Add(new[] {0, 0, 0, 0, 1, 0, 1, 0, 0.568965517241379, 0.0581717451523546});
            results.Add(new double[] {0, 1, 0});
            inputs.Add(new[] {0, 0, 0, 0, 1, 0, 0, 1, 0.310344827586207, 0.153277931671283});
            results.Add(new double[] {0, 1, 0});
            inputs.Add(new[] {0, 0, 0, 0, 1, 0, 0, 1, 0.482758620689655, 0.153277931671283});
            results.Add(new double[] {0, 1, 0});
            inputs.Add(new[] {0, 1, 0, 0, 0, 1, 0, 0, 0, 0.0120036934441367});
            results.Add(new double[] {0, 0, 1});
            inputs.Add(new[] {0, 0, 1, 0, 0, 0, 1, 0, 0.25, 0.00923361034164358});
            results.Add(new double[] {0, 0, 1});
            inputs.Add(new[] {0, 0, 0, 0, 1, 0, 1, 0, 0.641379310344828, 0.0166204986149584});
            results.Add(new double[] {0, 0, 1});
            inputs.Add(new[] {0, 0, 0, 0, 1, 0, 1, 0, 0.648275862068965, 0.0138504155124654});
            results.Add(new double[] {0, 0, 1});
            inputs.Add(new[] {0, 0, 0, 0, 1, 0, 1, 0, 0.387931034482759, 0.0480147737765466});
            results.Add(new double[] {0, 0, 1});
            inputs.Add(new[] {0, 0, 0, 0, 1, 1, 0, 0, 0.172413793103448, 1});
            results.Add(new double[] {0, 0, 1});
            inputs.Add(new[] {0, 0, 1, 0, 0, 1, 0, 0, 0.0637931034482759, 0.048938134810711});
            results.Add(new double[] {0, 0, 1});
            inputs.Add(new[] {0, 0, 0, 0, 1, 0, 1, 0, 0.258620689655172, 0.136657433056325});
            results.Add(new double[] {0, 0, 1});
            inputs.Add(new[] {0, 0, 0, 0, 1, 0, 1, 0, 0.78448275862069, 0.07202216066482});
            results.Add(new double[] {0, 0, 1});
            inputs.Add(new[] {0, 0, 1, 0, 0, 1, 0, 0, 0.0672413793103448, 0.0240073868882733});
            results.Add(new double[] {0, 0, 1});
            inputs.Add(new[] {0, 0, 0, 0, 1, 0, 1, 0, 0.629310344827586, 0.0397045244690674});
            results.Add(new double[] {0, 0, 1});
            inputs.Add(new[] {0, 0, 1, 0, 0, 1, 0, 0, 0.1, 0.193905817174515});
            results.Add(new double[] {0, 0, 1});


            return (network, inputs, results);
        }

        public static (Network, List<double[]>, List<double[]>) AirplaneModelAndNation()
        {
            int[] hiddenLayers = {4, 4, 4};
            var network = new Network(10, hiddenLayers, 38);

            List<double[]> inputs = new();
            List<double[]> results = new();

            inputs.Add(new[] {1, 1, 0, 0, 0, 1, 0, 0, 0.0724137931034483, 0.0221606648199446});
            results.Add(new double[]
            {
                1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0
            });
            inputs.Add(new[] {1, 1, 0, 0, 0, 1, 0, 0, 0.344827586206897, 0.0249307479224377});
            results.Add(new double[]
            {
                1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0
            });
            inputs.Add(new[] {0, 1, 0, 0, 0, 1, 0, 0, 0.137931034482759, 0.0110803324099723});
            results.Add(new double[]
            {
                1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0
            });
            inputs.Add(new[] {0, 1, 0, 0, 0, 1, 0, 0, 0.301724137931034, 0.316712834718375});
            results.Add(new double[]
            {
                1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0
            });
            inputs.Add(new[] {1, 0, 1, 0, 0, 0, 1, 0, 0.410344827586207, 0});
            results.Add(new double[]
            {
                1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0
            });
            inputs.Add(new[] {1, 0, 1, 0, 0, 0, 1, 0, 0.586206896551724, 0.00646352723915051});
            results.Add(new double[]
            {
                1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0
            });
            inputs.Add(new[] {0, 1, 0, 0, 0, 1, 0, 0, 0.310344827586207, 0.261311172668513});
            results.Add(new double[]
            {
                0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0
            });
            inputs.Add(new[] {0, 1, 0, 0, 0, 1, 0, 0, 0.482758620689655, 0.570637119113573});
            results.Add(new double[]
            {
                0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0
            });
            inputs.Add(new[] {0, 1, 0, 0, 0, 1, 0, 0, 0.310344827586207, 0.12280701754386});
            results.Add(new double[]
            {
                0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0
            });
            inputs.Add(new[] {1, 1, 0, 0, 0, 1, 0, 0, 0.310344827586207, 0.0729455216989843});
            results.Add(new double[]
            {
                0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0
            });
            inputs.Add(new[] {0, 1, 0, 0, 0, 1, 0, 0, 0.0172413793103448, 0.178208679593721});
            results.Add(new double[]
            {
                0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0
            });
            inputs.Add(new[] {0, 1, 0, 0, 0, 1, 0, 0, 0.310344827586207, 0.132040627885503});
            results.Add(new double[]
            {
                0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0
            });
            inputs.Add(new[] {1, 0, 0, 1, 0, 1, 0, 0, 0.189655172413793, 0.0535549399815328});
            results.Add(new double[]
            {
                0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0
            });
            inputs.Add(new[] {1, 0, 0, 1, 0, 1, 0, 0, 0.137931034482759, 0.0572483841181902});
            results.Add(new double[]
            {
                0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0
            });
            inputs.Add(new[] {0, 0, 1, 0, 0, 0, 1, 0, 1, 0.048938134810711});
            results.Add(new double[]
            {
                0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0
            });
            inputs.Add(new[] {1, 0, 1, 0, 0, 0, 1, 0, 0.482758620689655, 0.0517082179132041});
            results.Add(new double[]
            {
                0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0
            });
            inputs.Add(new[] {0, 0, 1, 0, 0, 0, 1, 0, 0.362068965517241, 0.0166204986149584});
            results.Add(new double[]
            {
                0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0
            });
            inputs.Add(new[] {0, 0, 1, 0, 0, 0, 1, 0, 0.482758620689655, 0.0120036934441367});
            results.Add(new double[]
            {
                0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0
            });
            inputs.Add(new[] {0, 0, 1, 0, 0, 0, 1, 0, 0.655172413793103, 0.0304709141274238});
            results.Add(new double[]
            {
                0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0
            });
            inputs.Add(new[] {0, 0, 0, 0, 1, 0, 1, 0, 0.482758620689655, 0.0397045244690674});
            results.Add(new double[]
            {
                0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0
            });
            inputs.Add(new[] {0, 0, 0, 0, 1, 0, 1, 0, 0.568965517241379, 0.0581717451523546});
            results.Add(new double[]
            {
                0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0
            });
            inputs.Add(new[] {0, 0, 0, 0, 1, 0, 0, 1, 0.310344827586207, 0.153277931671283});
            results.Add(new double[]
            {
                0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0
            });
            inputs.Add(new[] {0, 0, 0, 0, 1, 0, 0, 1, 0.482758620689655, 0.153277931671283});
            results.Add(new double[]
            {
                0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0
            });
            inputs.Add(new[] {0, 1, 0, 0, 0, 1, 0, 0, 0, 0.0120036934441367});
            results.Add(new double[]
            {
                0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0
            });
            inputs.Add(new[] {0, 0, 1, 0, 0, 0, 1, 0, 0.25, 0.00923361034164358});
            results.Add(new double[]
            {
                0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0
            });
            inputs.Add(new[] {0, 0, 0, 0, 1, 0, 1, 0, 0.641379310344828, 0.0166204986149584});
            results.Add(new double[]
            {
                0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0,
                0, 0, 0
            });
            inputs.Add(new[] {0, 0, 0, 0, 1, 0, 1, 0, 0.648275862068965, 0.0138504155124654});
            results.Add(new double[]
            {
                0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0,
                0, 0, 0
            });
            inputs.Add(new[] {0, 0, 0, 0, 1, 0, 1, 0, 0.387931034482759, 0.0480147737765466});
            results.Add(new double[]
            {
                0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0,
                0, 0, 0
            });
            inputs.Add(new[] {0, 0, 0, 0, 1, 1, 0, 0, 0.172413793103448, 1});
            results.Add(new double[]
            {
                0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0,
                0, 0, 0
            });
            inputs.Add(new[] {0, 0, 1, 0, 0, 1, 0, 0, 0.0637931034482759, 0.048938134810711});
            results.Add(new double[]
            {
                0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0,
                0, 0, 0
            });
            inputs.Add(new[] {0, 0, 0, 0, 1, 0, 1, 0, 0.258620689655172, 0.136657433056325});
            results.Add(new double[]
            {
                0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0,
                0, 0, 0
            });
            inputs.Add(new[] {0, 0, 0, 0, 1, 0, 1, 0, 0.78448275862069, 0.07202216066482});
            results.Add(new double[]
            {
                0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1,
                0, 0, 0
            });
            inputs.Add(new[] {0, 0, 1, 0, 0, 1, 0, 0, 0.0672413793103448, 0.0240073868882733});
            results.Add(new double[]
            {
                0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                1, 0, 0
            });
            inputs.Add(new[] {0, 0, 0, 0, 1, 0, 1, 0, 0.629310344827586, 0.0397045244690674});
            results.Add(new double[]
            {
                0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 1, 0
            });
            inputs.Add(new[] {0, 0, 1, 0, 0, 1, 0, 0, 0.1, 0.193905817174515});
            results.Add(new double[]
            {
                0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 1
            });


            return (network, inputs, results);
        }
    }
}