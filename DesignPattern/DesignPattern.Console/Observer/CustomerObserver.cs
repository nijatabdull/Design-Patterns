namespace DesignPattern.Console.Observer
{
    public class CustomerObserver : IProductObserver
    {
        public void Update()
        {
            System.Console.WriteLine("CostumerObserver is sent");
        }
    }
}
