namespace MyTestLibrary
{
    public class Calculator
    {
        public double Add (double a, double b)
        {
            return a + b;
        }
        public double Subtract (double a, double b)
        {
            return a - b;
        }
        public double Multiply ( double a, double b)
        {
            return a * b;
        }
        public double Divide (double a, int b)
        {
            double result;
            try
            {
                result = a / b;
                

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"An error occured. {ex.Message}");
                throw;
            }
            return result;
            
        }
    }
 }

