using System;
using BasicCalculator;
using StatOperations;

namespace StatisticsCalc
{
    public class StatisticsCalc : Calc
    {
        public dynamic Mean(dynamic values)
        { 
            result = StatOperations.StatOperations.Mean(values);

            return result;
        }
    }
}
