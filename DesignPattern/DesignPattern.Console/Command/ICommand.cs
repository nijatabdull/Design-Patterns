namespace DesignPattern.Console.Command
{
    public interface ICommand
    {
        double Execute(double value);
        double Undo(double value);
    }
}
