namespace DesignPattern.Console.Strategy
{
    public class PlusStrategy : IStrategy
    {
        public int Calculate(int a, int b)
        {
            return a + b;
        }
    }
}
