using System.Collections;

namespace DesignPattern.Console.Composite
{
    public class Employee : IPerson
    {
        public string Name { get; set; }

        List<IPerson> _persons  = new List<IPerson>();

        public IEnumerator<IPerson> GetEnumerator()
        {
            foreach (IPerson person in _persons)
            {
                yield return person;
            }
        }

        public void AddSubEmployee(IPerson person)
        {
            _persons.Add(person);
        }

        public void RemoveSubEmployee(IPerson person)
        {
            _persons.Remove(person);
        }

        public IPerson GetByIndex(int index)
        {
            return _persons[index];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
