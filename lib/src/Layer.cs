using System.Collections.Generic;

namespace lib
{
    public class Layer<T> where T : INeuron
    {
        public readonly int Id;

        // public double Bias = Randomness.R.NextDouble();
        public double Bias = 0;
        public List<T> Neurons = new();

        public Layer(int id)
        {
            Id = id;
        }
    }
}