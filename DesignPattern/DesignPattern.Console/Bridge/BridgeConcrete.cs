namespace DesignPattern.Console.Bridge
{
    public class BridgeConcrete : IBridge
    {
        public ISender Sender { get; set; }

        public void Send()
        {
            Sender.Send();
        }
    }
}
