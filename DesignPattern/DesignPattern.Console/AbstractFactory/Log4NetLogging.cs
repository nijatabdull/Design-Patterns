namespace DesignPattern.Console.AbstractFactory
{
    public class Log4NetLogging : ILogging
    {
        public override void Log(string message)
        {
            System.Console.WriteLine("Log4NetLogging");
        }
    }
}
