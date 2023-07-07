namespace DesignPattern.Console.Adapter
{
    public class SerilogAdapter : ILogger
    {
        public void Log(string message)
        {
            Serilog serilog = new Serilog();

            serilog.LogInfo(message);
        }
    }
}
