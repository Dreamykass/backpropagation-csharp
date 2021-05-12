using System;
using System.Collections.Generic;

namespace lib
{
    public static class MeanSquare
    {
        // page 236

        public static double Mean(List<double> values)
        {
            return values.Count == 0 ? 0 : Mean(values, 0, values.Count);
        }

        private static double Mean(IList<double> values, int start, int end)
        {
            double s = 0;

            for (var i = start; i < end; i++) s += values[i];

            return s / (end - start);
        }

        public static double RootMeanSquare(List<double> values)
        {
            return values.Count == 0 ? 0 : RootMeanSquare(values, 0, values.Count);
        }

        private static double RootMeanSquare(IList<double> values, int start, int end)
        {
            double s = 0;
            int i;
            for (i = start; i < end; i++) s += values[i] * values[i];

            return Math.Sqrt(s / (end - start));
        }

        // page 236
    }
}