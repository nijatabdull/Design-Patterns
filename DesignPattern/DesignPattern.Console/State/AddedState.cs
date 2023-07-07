namespace DesignPattern.Console.State
{
    public class AddedState : IState
    {
        public void Handle(Context context)
        {
            context.SetState(this);
            System.Console.WriteLine("State: Added");
        }
    }
}
