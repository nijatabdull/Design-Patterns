namespace DesignPattern.Console.AbstractFactory
{
    public abstract class AbstractFactory
    {
        public abstract ICaching CreateCaching();
        public abstract ILogging CreateLogging();
    }
}
