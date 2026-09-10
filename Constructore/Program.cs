using System;


//Default Constructor
class Employee
{
    public int Id;
    public string Name;

    public Employee()
    {
        Id = 1;
        Name = "Titiksha Jangid";
    }
}


//Parameterized Constructor

class Employees
{
    public int Id;
    public string Name;

    public Employees(int id, string name)
    {
        Id = id;
        Name = name;
    }
}
class Program
{
    static void Main()
    {
        Employee employee = new Employee();

        Console.WriteLine($"ID: {employee.Id}");
        Console.WriteLine($"ID:{employee.Name}");
        Console.WriteLine();

        //---------------------------------------
        Employees emp = new Employees(101, "Titiksha");

        Console.WriteLine($"ID: {emp.Id}");
        Console.WriteLine($"Name: {emp.Name}");
    }
}

