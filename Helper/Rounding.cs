using System;
using System.Collections.Generic;
using System.Text;

namespace Helper
{
    public class Rounding
    {
        public static double RoundNumberToDecimalPlaces(int decimalPlace, double value)
        {
            return Math.Round(value, decimalPlace, MidpointRounding.ToEven);
        }
    }
}
