using System;
using System.Collections.Generic;
using System.Text;

namespace StatsStandardDevCalc
{
    public class StandardDevCalc
    {
        public static dynamic result;
        public double StandardDev(dynamic arrayA)
        {
            result = StatOperations.StatsStandardDev.StandardDev(arrayA);
            return result;
        }
    }
}
