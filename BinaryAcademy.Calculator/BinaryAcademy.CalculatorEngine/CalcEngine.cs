using System;

namespace BinaryAcademy.CalculatorEngine.Core
{
    public class CalcEngine
    {
        private readonly ICalculator calculator;
        private readonly IDistributor distributor;

        public CalcEngine(ICalculator calculator, IDistributor distributor)
        {
            this.calculator = calculator;
            this.distributor = distributor;
        }

        public void Add(double leftArg, double rightArg)
        {
            distributor.Write(calculator.Add(leftArg, rightArg));
        }

        public void Subtract(double leftArg, double rightArg)
        {
            distributor.Write(calculator.Subtract(leftArg, rightArg));
        }

        public void Multiple(double leftArg, double rightArg)
        {
            distributor.Write(calculator.Myltiply(leftArg, rightArg));
        }

        public void Divide(double leftArg, double rightArg)
        {
            try
            {
                distributor.Write(calculator.Divide(leftArg, rightArg));
            }
            catch (DivideByZeroException exception)
            {
                distributor.Write(exception.Message);                
            }
        }
    }
}
