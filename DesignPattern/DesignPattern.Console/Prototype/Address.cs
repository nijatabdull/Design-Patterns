namespace DesignPattern.Console.Prototype
{
    public class Address : ICloneable
    {
        public string Street { get; set; }
        public string City { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
