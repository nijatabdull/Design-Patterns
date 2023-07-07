namespace DesignPattern.Console.AbstractFactory
{
    public class RedisCaching : ICaching
    {
        public override void Set(string key, object value)
        {
            System.Console.WriteLine("RedisCaching");
        }
    }
}
