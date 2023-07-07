namespace DesignPattern.Console.AbstractFactory
{
    public class NlogLogging : ILogging
    {
        public override void Log(string message)
        {
            System.Console.WriteLine("NlogLogging");
        }
    }
}
