namespace DesignPattern.Console.Bridge
{
    public class SmsSender : ISender
    {
        public void Send()
        {
            System.Console.WriteLine("Message was sent via smsSender");
        }
    }
}
