namespace DesignPattern.Console.Mediator
{
    public class Student : CourseMember
    {
        public Student(Mediator mediator) : base(mediator)
        {
        }

        public override string Name { get; set; }

        public void RecieveImage(string url)
        {
            System.Console.WriteLine($"{Name} recieved image: {url}");
        }

        public void RecieveAnswer(string answer)
        {
            System.Console.WriteLine($"Student recieved answer: '{answer}'");
        }

        public void AskQuestion(string question)
        {
            System.Console.WriteLine($"Student asked question: '{question}'");
            Mediator.SendQuestion(question,this);
        }
    }
}
