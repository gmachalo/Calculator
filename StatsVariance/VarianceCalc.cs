using System;
using System.Collections.Generic;
using System.Text;
using StatOperations;

namespace StatsVarianceCalc
{
    public class VarianceCalc
    {
        public static dynamic result;
        public double Variance(dynamic arrayA)
        {
            result = StatOperations.StatsVariance.Variance(arrayA);
            return result;
        }
    }
}
