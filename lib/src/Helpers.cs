using System;
using System.Collections.Generic;
using System.Linq;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;

namespace lib
{
    public static class Helpers
    {
        private static string To4DecimalPlaces(double d)
        {
            // return String.Format("{0:0.000}", Math.Truncate(d * 10000) / 10000);
            return string.Format($"{d:0.000}");
        }

        public static string ArrayToString(IEnumerable<double> array)
        {
            return "[" + string.Join(",", array.Select(p => To4DecimalPlaces(p).ToString()).ToArray()) + "]";
        }

        public static string ArrayToString<T>(IEnumerable<T> array)
        {
            return "[" + string.Join(",", array.Select(p => p.ToString()).ToArray()) + "]";
        }

        public static Matrix<double> MatrixRotate(Matrix<double> matrix)
        {
            var reversedColumns = matrix.EnumerateColumns().Select(c => c.Reverse());
            return DenseMatrix.OfColumns(reversedColumns);
        }

        public static IEnumerable<IEnumerable<T>> CartesianProduct<T>(IEnumerable<IEnumerable<T>> sequences)
        {
            IEnumerable<IEnumerable<T>> emptyProduct = new[] {Enumerable.Empty<T>()};
            return sequences.Aggregate(
                emptyProduct,
                (accumulator, sequence) =>
                    from accseq in accumulator
                    from item in sequence
                    select accseq.Concat(new[] {item}));
        }

        public static IEnumerable<Tuple<T, T>> SlidingWindow<T>(IEnumerable<T> source)
        {
            return source.Zip(source.Skip(1), (a, b) => Tuple.Create(a, b));
        }

        private static bool DoubleBetween(double n, double a, double b)
        {
            return n >= a && n <= b;
        }

        public static void ConsoleWriteError(double err)
        {
            if (DoubleBetween(err, 0, 0.05)) Console.ForegroundColor = ConsoleColor.Green;
            else if (DoubleBetween(err, 0.05, 0.1)) Console.ForegroundColor = ConsoleColor.Cyan;
            else if (DoubleBetween(err, 0.1, 0.2)) Console.ForegroundColor = ConsoleColor.Yellow;
            else if (DoubleBetween(err, 0.2, 0.3)) Console.ForegroundColor = ConsoleColor.Magenta;
            else if (DoubleBetween(err, 0.3, 1.0)) Console.ForegroundColor = ConsoleColor.Red;
            else Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.Write(string.Format($"{err:0.0000000000}"));
            Console.Write("\n");

            Console.ResetColor();
        }

        public static double Clamp(double n, double min, double max)
        {
            if (n < min)
                return min;
            if (n > max)
                return max;
            return n;
        }
    }
}