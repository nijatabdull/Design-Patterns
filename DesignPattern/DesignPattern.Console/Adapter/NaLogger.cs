namespace DesignPattern.Console.Adapter
{
    public class NaLogger : ILogger
    {
        public void Log(string message)
        {
            System.Console.WriteLine("NaLogger logged");
        }
    }
}
