namespace DesignPattern.Console.Strategy
{
    public class MinusStrategy : IStrategy
    {
        public int Calculate(int a, int b)
        {
            return a - b;
        }
    }
}
