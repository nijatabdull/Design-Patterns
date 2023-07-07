namespace DesignPattern.Console.Bridge
{
    public interface IBridge
    {
        ISender Sender { get; set; }
        void Send();
    }
}
