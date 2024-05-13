var calculator = new Calculator();

while (true)
{
    Console.WriteLine("Enter X: ");
    if (!int.TryParse(Console.ReadLine(), out int x))
    {
        Console.WriteLine("Invalid input.");
        Console.Read();

        continue;
    }

    Console.WriteLine("Enter Y: ");
    if (!int.TryParse(Console.ReadLine(), out int y))
    {
        Console.WriteLine("Invalid input.");
        Console.Read();
        continue;
    }

    Console.WriteLine("What do you want to do: (add/sub/mul/div)");
    var response = Console.ReadLine();

    switch (response.ToLower())
    {
        case "add":
            var result1 = calculator.Add(x, y);
            Console.WriteLine(result1);
            break;

        case "sub":
            var result2 = calculator.Subtract(x, y);
            Console.WriteLine(result2);
            break;

        case "mul":
            var result3 = calculator.Multiply(x, y);
            Console.WriteLine(result3);
            break;

        case "div":
            var result4 = calculator.Divide(x, y);
            Console.WriteLine(result4);
            break;

        default:
            Console.WriteLine("Error not found.");
            break;
    }

    Console.WriteLine("Do you want to see the history: (y/n)");
    var res = Console.ReadLine();

    if (res == "y")
    {
        calculator.PrintHistory();
        Console.Read();
    }

    Console.Clear();
}