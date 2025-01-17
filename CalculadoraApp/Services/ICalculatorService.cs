namespace CalculadoraApp.Services
{
    public interface ICalculatorService
    {
        double Add(double a, double b);
        double Subtract(double a, double b);
        double Multiply(double a, double b);
        double Divide(double a, double b);
        double Power(double baseValue, double exponent);
        double SquareRoot(double value);
        int Factorial(int value);
    }
}
