namespace Calculator.Tests
{
    public class Calculate
    {
        public static double Add(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public static double Substract(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public static double Multiply(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public static double Divide(double firstNumber, double secondNumber)
        {
            if (secondNumber != 0)
            {
                return firstNumber / secondNumber;
            }
            else
            {
                return 0;
            }
        }
    }
}