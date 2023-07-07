namespace DesignPattern.Console.Adapter
{
    public class Serilog
    {
        public void LogInfo(string message)
        {
            System.Console.WriteLine("Serilog");
        }
    }
}
