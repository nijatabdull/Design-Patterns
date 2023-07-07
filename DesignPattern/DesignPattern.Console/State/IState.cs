namespace DesignPattern.Console.State
{
    public interface IState
    {
        void Handle(Context context);
    }
}
