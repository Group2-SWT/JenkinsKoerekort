using System;

namespace Calculator
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Substraction(double a, double b)
        {
            return a - b;
        }
        public double Multiply(double a, double b)
        {
            return a * b;
        }
        public double Power(double x, double exp)
        {
            if (exp == 0)
            {
                if (x > 0) return 1;
                else
                {
                    return -1;
                }
            }
            return Math.Pow(x, exp);
        }
        public double Divide(double divided, double divisor)
        {
            return divided / divisor;
        }

        public double SquareRoot(double a)
        {
            return Math.Sqrt(a);
        }

    }
}
