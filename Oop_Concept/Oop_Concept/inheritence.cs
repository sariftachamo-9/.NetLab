using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Concept
{
    //interface for addition
    interface IAddition
    {
        int add(int a, int b);
    }

    //interface for subtraction
    interface ISubtraction
    {
        int subtract(int a, int b);
    }

    //interface for multiplication
    interface IMultiplication
    {
        int Multiplier(int a, int b);
    }

    //interface for division
    interface IDivision
    {
        int Division(int a, int b); // double division(double a, double b); for the double data
    }


    //class implementation for math operation
    public class MathOperation1 : IAddition, ISubtraction, IMultiplication, IDivision
    {
        public int add(int a, int b)
        {
            return a + b;
        }
        public int subtract(int a, int b)
        {
            return a - b;
        }
        public int Multiplier(int a, int b)
        {
            return a * b;
        }
        public int Division(int a, int b)///public double division (double a, double b)
        {
            if (b == 0)

            {

                throw new DivideByZeroException("Cannot divide by zero.");

            }
            return a / b;
        }
    }
}
