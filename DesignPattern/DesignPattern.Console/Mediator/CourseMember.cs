namespace DesignPattern.Console.Mediator
{
    public abstract class CourseMember
    {
        protected Mediator Mediator { get; set; }

        protected CourseMember(Mediator mediator)
        {
            Mediator = mediator;
        }

        public abstract string Name { get; set; }
    }
}
