namespace DesignPattern.Console.State
{
    public class ModifiedState : IState
    {
        public void Handle(Context context)
        {
            context.SetState(this);
            System.Console.WriteLine("State: Modified");
        }
    }
}
