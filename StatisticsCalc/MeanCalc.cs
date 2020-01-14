using BasicCalculator;

namespace StatisticsCalc
{
    public class MeanCalc : Calc, IMeanCalc
    {
        public dynamic Mean(dynamic values)
        {
            result = StatOperations.StatsMean.Mean(values);

            return result;
        }
    }
}