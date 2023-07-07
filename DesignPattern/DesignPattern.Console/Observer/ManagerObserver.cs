namespace DesignPattern.Console.Observer
{
    public class ManagerObserver : IProductObserver
    {
        public void Update()
        {
            System.Console.WriteLine("ManagerObserver is sent");
        }
    }
}
