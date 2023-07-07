namespace DesignPattern.Console.AbstractFactory
{
    public class RedisSerilogFactory : AbstractFactory
    {
        public override ICaching CreateCaching()
        {
            return new RedisCaching();
        }

        public override ILogging CreateLogging()
        {
            return new SerilogLogging();
        }
    }
}
