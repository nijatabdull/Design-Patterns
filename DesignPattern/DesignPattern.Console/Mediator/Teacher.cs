namespace DesignPattern.Console.Mediator
{
    public class Teacher : CourseMember
    {
        public Teacher(Mediator mediator) : base(mediator)
        {
        }

        public override string Name { get; set; }

        public void RecieveQuestion(string question, Student student)
        {
            System.Console.WriteLine($"Teacher recieved a question from '{student.Name}' with this question: '{question}'");
        }

        public void SendNewImageUrl(string url)
        {
            System.Console.WriteLine($"Teacher changed slide: {url}");
            Mediator.UpdateImage(url);
        }

        public void AnswerQuestion(string answer, Student student)
        {
            System.Console.WriteLine($"Teacher answered question: '{answer}' to '{student.Name}'");
            Mediator.SendAnswer(answer, student);
        }
    }
}
