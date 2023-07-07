namespace DesignPattern.Console.Composite
{
    public interface IPerson : IEnumerable<IPerson>
    {
        string Name { get; set; }
    }
}
