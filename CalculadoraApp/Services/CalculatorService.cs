using System;

namespace CalculadoraApp.Services
{
    public class CalculatorService : ICalculatorService
    {
        public double Add(double a, double b) => a + b;
        public double Subtract(double a, double b) => a - b;
        public double Multiply(double a, double b) => a * b;
        public double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException();
            return a / b;
        }
        public double Power(double baseValue, double exponent) => Math.Pow(baseValue, exponent);
        public double SquareRoot(double value) => Math.Sqrt(value);
        public int Factorial(int value)
        {
            if (value < 0)
                throw new ArgumentException("Value must be non-negative.");
            return value == 0 ? 1 : value * Factorial(value - 1);
        }
    }
}
