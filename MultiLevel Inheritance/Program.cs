using System;

class Person
{
    public void ShowPerson()
    {
        Console.WriteLine("I am a person");
    }
}

class Employee : Person
{
    public void ShowEmployee()
    {
        Console.WriteLine("I am an employee");
    }
}

class Developer : Employee
{
    public void ShowDeveloper()
    {
        Console.WriteLine("I am a developer");
    }
}

class Program
{
    static void Main()
    {
        Developer developer = new Developer();

        developer.ShowPerson();
        developer.ShowEmployee();
        developer.ShowDeveloper();
    }
}