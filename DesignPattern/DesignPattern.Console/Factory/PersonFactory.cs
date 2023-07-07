namespace DesignPattern.Console.Factory
{
    public class PersonFactory : IFactory
    {
        public IPerson GetPerson()
        {
            return new Person();
        }
    }
}
