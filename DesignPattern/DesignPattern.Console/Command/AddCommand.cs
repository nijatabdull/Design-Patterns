namespace DesignPattern.Console.Command
{
    public class AddCommand : ICommand
    {
        private readonly double _valieToAdd;

        public AddCommand(double valieToAdd)
        {
            _valieToAdd = valieToAdd;
        }

        public double Execute(double value)
        {
            return value += _valieToAdd;
        }

        public double Undo(double value)
        {
            return value -= _valieToAdd;
        }
    }
}
