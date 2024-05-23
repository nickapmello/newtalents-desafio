using Xunit;
using CalculadoraApp.Services;

namespace CalculadoraApp.Tests
{
    public class CalculatorServiceTests
    {
        private readonly ICalculatorService _calculatorService;

        public CalculatorServiceTests()
        {
            _calculatorService = new CalculatorService();
        }

        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            // Arrange
            double a = 5;
            double b = 3;

            // Act
            double result = _calculatorService.Add(a, b);

            // Assert
            Assert.Equal(8, result);
        }

        [Fact]
        public void Subtract_ShouldReturnCorrectDifference()
        {
            // Arrange
            double a = 5;
            double b = 3;

            // Act
            double result = _calculatorService.Subtract(a, b);

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void Multiply_ShouldReturnCorrectProduct()
        {
            // Arrange
            double a = 5;
            double b = 3;

            // Act
            double result = _calculatorService.Multiply(a, b);

            // Assert
            Assert.Equal(15, result);
        }

        [Fact]
        public void Divide_ShouldReturnCorrectQuotient()
        {
            // Arrange
            double a = 6;
            double b = 3;

            // Act
            double result = _calculatorService.Divide(a, b);

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void Divide_ShouldThrowDivideByZeroException()
        {
            // Arrange
            double a = 6;
            double b = 0;

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => _calculatorService.Divide(a, b));
        }

        [Fact]
        public void Power_ShouldReturnCorrectResult()
        {
            // Arrange
            double baseValue = 2;
            double exponent = 3;

            // Act
            double result = _calculatorService.Power(baseValue, exponent);

            // Assert
            Assert.Equal(8, result);
        }

        [Fact]
        public void SquareRoot_ShouldReturnCorrectResult()
        {
            // Arrange
            double value = 9;

            // Act
            double result = _calculatorService.SquareRoot(value);

            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void Factorial_ShouldReturnCorrectResult()
        {
            // Arrange
            int value = 5;

            // Act
            int result = _calculatorService.Factorial(value);

            // Assert
            Assert.Equal(120, result);
        }

        [Fact]
        public void Factorial_ShouldThrowArgumentExceptionForNegativeInput()
        {
            // Arrange
            int value = -1;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => _calculatorService.Factorial(value));
        }
    }
}
