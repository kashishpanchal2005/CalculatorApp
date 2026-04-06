using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Simple Calculator");

        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter operator (+, -, *, /): ");
        string op = Console.ReadLine();

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = 0;

        if (op == "+")
            result = num1 + num2;
        else if (op == "-")
            result = num1 - num2;
        else if (op == "*")
            result = num1 * num2;
        else if (op == "/")
            result = num1 / num2;

        Console.WriteLine("Result: " + result);
    }
}
