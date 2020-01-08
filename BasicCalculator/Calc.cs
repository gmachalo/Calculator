using System;
using operations;

namespace BasicCalculator
{
    public class Calc
    {
        public int result;

        public int Add(int a, int b)
        {
            result = Addition.Sum(a, b);
            return result;
        }
        public int Div(int a, int b)
        {
            result = Division.Quot(a, b);
            return result;
        }
    }
}
