using MyTestLibrary;

namespace MyCalculatorTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Add_ReturnsCorrectResult()
        {
            var calculator = new Calculator();
            double a = 10;
            double b = 20;

            double result = calculator.Add(a, b);

            Assert.AreEqual(30, result);
        }

        [TestMethod]
        public void Subtract_ReturnsCorrectResult()
        {
            var calculator = new Calculator();
            double a = 20;
            double b = 10;

            double result = calculator.Subtract(a, b);

            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void Multiply_ReturnsCorrectResult()
        {
            var calculator = new Calculator();
            double a = 10;
            double b = 5;

            double result = calculator.Multiply(a, b);

            Assert.AreEqual(50, result);
        }

        [TestMethod]
        public void Divide_ReturnsCorrectResult()
        {
            var calculator = new Calculator();
            double a = 10;
            double b = 2;

            double result = calculator.Divide(a, b);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Add_LargeNumbers_ReturnsCorrectResult()
        {
            var calculator = new Calculator();
            double a = double.MaxValue - 100;
            double b = 50;

            double result = calculator.Add(a, b);

            Assert.AreEqual(double.MaxValue - 50, result);
        }

        [TestMethod]
        public void Divide_SmallNumbers_ReturnsCorrectResult()
        {
            var calculator = new Calculator();
            double a = double.MinValue;
            double b = 5;

            double result = calculator.Divide(a, b);

            Assert.AreEqual(double., result);
        }
    }
}
