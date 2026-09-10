using System;

abstract class Shape
{
    public abstract double CalculateArea();

    public void DisplayMessage()
    {
        Console.WriteLine("Calculating shape area...");
    }
}

class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

class Program
{
    static void Main()
    {
        Shape shape = new Circle(5);

        shape.DisplayMessage();
        Console.WriteLine($"Area: {shape.CalculateArea():F2}");
    }
}