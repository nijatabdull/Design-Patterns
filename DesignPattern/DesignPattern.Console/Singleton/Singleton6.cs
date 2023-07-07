namespace DesignPattern.Console.Singleton
{
    public sealed class Singleton6
    {
        private readonly static Lazy<Singleton6> lazy = new(() => new Singleton6());

        private Singleton6() { }

        public static Singleton6 Instance { get { return lazy.Value; } }
    }
}
