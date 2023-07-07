using DesignPattern.Console.Command;

Calculator calculator = new Calculator();

calculator.ExecuteCommand(new AddCommand(20));
Console.WriteLine(calculator.CurrentValue);

calculator.ExecuteCommand(new SubtractCommand(10));
Console.WriteLine(calculator.CurrentValue);

calculator.ExecuteCommand(new MultiplyCommand(5));
Console.WriteLine(calculator.CurrentValue);

calculator.Undo();
Console.WriteLine(calculator.CurrentValue);

calculator.Undo();
Console.WriteLine(calculator.CurrentValue);

calculator.Undo();
Console.WriteLine(calculator.CurrentValue);


Console.WriteLine();