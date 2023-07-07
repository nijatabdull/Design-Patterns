namespace DesignPattern.Console.Prototype
{
    public class Empoyee : Person
    {
        public string Email { get; set; }

        public Address Address { get; set; }

        public override Person Clone()
        {
            Empoyee clone = (Empoyee)MemberwiseClone();

            clone.Address= (Address)clone.Address.Clone();

            return clone;
        }
    }
}
