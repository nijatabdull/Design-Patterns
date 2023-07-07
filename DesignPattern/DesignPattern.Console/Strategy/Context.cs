namespace DesignPattern.Console.Strategy
{
    public class Context
    {
        private readonly IStrategy _strategy;

        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public int Calculate(int a, int b)
        {
            return _strategy.Calculate(a, b);
        }
    }
}
