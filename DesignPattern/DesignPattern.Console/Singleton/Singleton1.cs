namespace DesignPattern.Console.Singleton
{
    /// <summary>
    /// No Thread Singleton
    /// </summary>
    public sealed class Singleton1
    {
        private Singleton1() 
        { 
        
        }

        private static Singleton1 instance;

        public static Singleton1 Instance
        {
            get
            {
                return instance ?? new Singleton1();
            }
        }
    }
}