using System;

namespace BinaryAcademy.CalculatorEngine.Core
{
    public interface ICalculator
    {
        double Add(double leftArg, double rightArg);
        double Subtract(double leftArg, double rightArg);
        double Myltiply(double leftArg, double rightArg);
        double Divide(double leftArg, double rightArg);
    }

    public class SimpleCalculator : ICalculator
    {
        public double Add(double leftArg, double rightArg)
        {
            return leftArg + rightArg;
        }

        public double Subtract(double leftArg, double rightArg)
        {
            return leftArg - rightArg;
        }

        public double Myltiply(double leftArg, double rightArg)
        {
            return leftArg * rightArg;
        }

        public double Divide(double leftArg, double rightArg)
        {
            if (Math.Abs(rightArg) < 10e-9)
                throw new DivideByZeroException(("Error: Division by zero was performed!"));
            return leftArg / rightArg;
        }
    }
}
