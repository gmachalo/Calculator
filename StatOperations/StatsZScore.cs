using System;
using System.Collections.Generic;
using System.Text;
using operations;

namespace StatOperations
{
    public class StatsZScore
    {
        public static double StatZScore(dynamic score, dynamic values)
        {
            double mean = StatsMean.Mean(values);
            double standDev = StatsStandardDev.StandardDev(values);
            double zScore = Division.Quot(Subtraction.Difference(score, mean), standDev);
            return zScore;
        }
    }
}