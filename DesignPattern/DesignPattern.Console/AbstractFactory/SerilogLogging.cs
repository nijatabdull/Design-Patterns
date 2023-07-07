namespace DesignPattern.Console.AbstractFactory
{
    public class SerilogLogging : ILogging
    {
        public override void Log(string message)
        {
            System.Console.WriteLine("SerilogLogging");
        }
    }
}
