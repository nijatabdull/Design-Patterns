namespace DesignPattern.Console.Decorator
{
    public abstract class Decorator : CarBase
    {
        private protected readonly CarBase _carBase;
        protected Decorator(CarBase carBase)
        {
            _carBase = carBase;
        }
    }
}
