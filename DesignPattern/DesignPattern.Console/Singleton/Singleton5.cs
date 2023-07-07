namespace DesignPattern.Console.Singleton
{
    /// <summary>
    /// Thread-safe - fully lazy instantiation
    /// </summary>
    public sealed class Singleton5
    {
        private Singleton5() 
        {
        
        }

        public static Singleton5 Instance
        {
            get
            {
                return Nested.instance;
            }
        }

        private class Nested
        {
            static Nested()
            {
                
            }

            internal static readonly Singleton5 instance = new Singleton5();
        }
    }
}
