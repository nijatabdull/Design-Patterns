namespace DesignPattern.Console.Bridge
{
    public class MailSender : ISender
    {
        public void Send()
        {
            System.Console.WriteLine("Message was sent via mailsender");
        }
    }
}
