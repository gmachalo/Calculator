using System;
using operations;
using Add;
using Divide;
using Multiply;
using Subtract;
using Root;
using SquareInterface;
using CubeInterface;

namespace BasicCalculator
{
    
    public class Calc : IAdd, IDivide, ICubeInterface, IMultiply, IRoot, ISquareInterface, ISubtract
    {
        Adding add = new Adding();
        Div divide = new Div();
        Subtracting subtract = new Subtracting();
        Multiplying multiply = new Multiplying();
        Squaring square = new Squaring();
        Cubing cube = new Cubing();
        Rooting root = new Rooting();
        public dynamic result;

        public dynamic Add(dynamic a, dynamic b)
        {
            result = add.Add(a, b);
            return result;
        }

        public dynamic Add(dynamic values)
        {
            result = add.Add(values);
            return result;
        }

        public dynamic Divide(dynamic a, dynamic b)
        {
            result = divide.Divide(a, b);
            return result;
        }

        public dynamic Subtract(dynamic a, dynamic b)
        {
            result = subtract.Subtract(a, b);
            return result;
        }

        public dynamic Multiply(dynamic a, dynamic b)
        {
            result = multiply.Multiply(a, b);
            return result;
        }

        public dynamic SquareInterface(dynamic a)
        {
            result = square.SquareInterface(a);
            return result;
        }

        public dynamic CubeInterface(dynamic a)
        {
            result = cube.CubeInterface(a);
            return result;
        }

        public dynamic Root(dynamic a)
        {
            result = root.Root(a);
            return result;
        }

    }
}
