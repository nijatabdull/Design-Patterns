namespace DesignPattern.Console.Command
{
    public class Calculator
    {
        public double CurrentValue { get; private set; }

        public Stack<ICommand> _commandHistory = new Stack<ICommand>();

        public void ExecuteCommand(ICommand command)
        {
            CurrentValue = command.Execute(CurrentValue);
            _commandHistory.Push(command);
        }

        public void Undo()
        {
            ICommand command = _commandHistory.Pop();
            CurrentValue = command.Undo(CurrentValue);
        }
    }
}
