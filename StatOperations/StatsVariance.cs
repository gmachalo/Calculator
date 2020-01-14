using System;
using System.Collections.Generic;
using System.Text;
using operations;

namespace StatOperations
{
    public class StatsVariance
    {
        public static double Variance(dynamic values)
        {
            double mean = StatsMean.Mean(values);
            double[] squareDeviation = new double[Helper.Array.Length(values)];
            int i = 0;
            foreach (int a in values)
            {
                squareDeviation[i] = Square.Squared(Subtraction.Difference(a, mean));
                i++;
            }
            double variance = StatsMean.Mean(squareDeviation);
            return variance;
        }
    }
}
