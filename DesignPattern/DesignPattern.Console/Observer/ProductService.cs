namespace DesignPattern.Console.Observer
{
    public class ProductService
    {
        private IList<IProductObserver> _productObservers = new List<IProductObserver>();
        public void Update()
        {
            System.Console.WriteLine("Updated in db");
            Notify();
        }

        public void Attach(IProductObserver observer)
        {
            _productObservers.Add(observer);
        }

        public void Detach(IProductObserver observer)
        {
            _productObservers.Remove(observer);
        }

        public void Notify()
        {
            foreach (IProductObserver observer in _productObservers)
            {
                observer.Update();
            }
        }
    }
}
