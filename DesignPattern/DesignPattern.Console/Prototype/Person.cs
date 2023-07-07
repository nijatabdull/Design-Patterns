namespace DesignPattern.Console.Prototype
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public abstract Person Clone();
    }
}
