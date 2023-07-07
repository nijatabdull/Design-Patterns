namespace DesignPattern.Console.Singleton
{
    /// <summary>
    /// Thread-Safety Singleton
    /// </summary>
    public sealed class Singleton2
    {
        private Singleton2() 
        {
        
        }

        private static Singleton2 _instance;
        private static readonly object _padlock = new object();

        public static Singleton2 Instance
        {
            get
            {
                lock (_padlock)
                {
                    return _instance ?? new Singleton2();
                }
            }
        }
    }
}
