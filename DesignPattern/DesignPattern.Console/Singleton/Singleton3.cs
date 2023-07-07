namespace DesignPattern.Console.Singleton
{
    /// <summary>
    /// Thread-safety Singleton using double-check locking
    /// </summary>
    public sealed class Singleton3
    {
        private Singleton3() 
        {
        
        }
        private static Singleton3 instance;

        private readonly static object instanceLock = new object();

        public static Singleton3 Instance
        {
            get
            {
                if(instance == null)
                {
                    lock (instanceLock)
                    {
                        if (instance == null)
                        {
                            return new Singleton3();
                        }
                    }
                }

                return instance;
            }
        }
    }
}
