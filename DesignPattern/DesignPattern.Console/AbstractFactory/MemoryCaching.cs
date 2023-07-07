namespace DesignPattern.Console.AbstractFactory
{
    public class MemoryCaching : ICaching
    {
        public override void Set(string key, object value)
        {
            System.Console.WriteLine("MemoryCaching");
        }
    }
}
