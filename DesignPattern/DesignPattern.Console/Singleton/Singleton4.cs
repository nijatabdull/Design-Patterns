namespace DesignPattern.Console.Singleton
{
    /// <summary>
    /// Not quite as lazy, thread-safe without using lock
    /// </summary>
    public sealed class Singleton4
    {
        private readonly static Singleton4 instance = new();

        static Singleton4()
        {

        }
        private Singleton4()
        {

        }

        public static Singleton4 Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
