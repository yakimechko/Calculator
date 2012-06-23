namespace BinaryAcademy.CalculatorEngine.Core
{
    public interface IDistributor
    {
        void Write(object arg);
    }

    public class ConsoleDistributor : IDistributor
    {
        public void Write(object arg)
        {
            System.Console.WriteLine(arg);
        }
    }

    public class FileDistributor : IDistributor
    {
        public void Write(object arg)
        {
            System.IO.File.WriteAllText("result.txt", arg.ToString());
        }
    }
}