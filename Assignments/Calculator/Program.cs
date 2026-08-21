Console.WriteLine("Hello!");

Console.WriteLine("Input the first number:");
int numberOne = ReadNumber();

Console.WriteLine("Input the second number:");
int numberTwo = ReadNumber();

Console.WriteLine("What do you want to do with those numbers?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");

switch (Console.ReadLine()?.ToUpperInvariant())
{
    case "A":
        PrintFinalEquation(numberOne, "+", numberTwo, Add(numberOne, numberTwo));
        break;
    case "S":
        PrintFinalEquation(numberOne, "-", numberTwo, Subtract(numberOne, numberTwo));
        break;
    case "M":
        PrintFinalEquation(numberOne, "*", numberTwo, Multiply(numberOne, numberTwo));
        break;
    default:
        Console.WriteLine("Invalid option");
        break;
}

Console.WriteLine("Press any key to close.");
Console.ReadKey();

int Add(int num1, int num2)
    => num1 + num2;

int Subtract(int num1, int num2)
    => num1 - num2;

int Multiply(int num1, int num2)
    => num1 * num2;

int ReadNumber() 
    => int.Parse(Console.ReadLine());

void PrintFinalEquation(int num1, string @operator, int num2, int result)
    => Console.WriteLine($"{num1} {@operator} {num2} = {result}");

return 0;
