namespace BinaryAcademy.CalculatorEngine.Core
{
    public interface IDistributor
    {
        void Write(double arg);
    }

    public class ConsoleDistributor : IDistributor
    {
        public void Write(double arg)
        {
            System.Console.WriteLine(double.IsNaN(arg) ?
                "Division by zero was performed." : arg.ToString());
        }
    }

    public class FileDistributor : IDistributor
    {
        public void Write(double arg)
        {
            System.IO.File.WriteAllText("result.txt",
                double.IsNaN(arg) ? "Division by zero was performed." : arg.ToString());
        }
    }
}