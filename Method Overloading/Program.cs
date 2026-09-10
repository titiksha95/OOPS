using System;

class Calculator
{
    public int Add(int number1, int number2)
    {
        return number1 + number2;
    }

    public int Add(int number1, int number2, int number3)
    {
        return number1 + number2 + number3;
    }

    public double Add(double number1, double number2)
    {
        return number1 + number2;
    }
}

class Program
{
    static void Main()
    {
        Calculator calculator = new Calculator();

        Console.WriteLine(calculator.Add(10, 20));
        Console.WriteLine(calculator.Add(10, 20, 30));
        Console.WriteLine(calculator.Add(10.5, 20.5));
    }
}