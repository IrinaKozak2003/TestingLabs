using System;

namespace Calculator.Properties
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Subtract(int a, int b)
        {
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public int Divide(int a, int b)
        {
            return a / b;
        }
        public float Modulus(int a, int b)
        {
            return a % b;
        }
        public int Power(int a, int b)
        {
            return (int)Math.Pow(a, b);
        }
        public int SquareRoot(int a)
        {
            return (int)Math.Sqrt(a);
        }
    }
}