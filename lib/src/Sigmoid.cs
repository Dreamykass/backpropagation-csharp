using System;

namespace lib
{
    public class Sigmoid
    {
        public static double Activator(double x)
        {
            return 1.0 / (1.0 + Math.Exp(-x));
            // return 1.0f / (1.0f + (float) Math.Exp(-x));
        }

        public static double Derivative(double x)
        {
            return x * (1 - x);
        }
    }
}