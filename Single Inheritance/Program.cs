using System;

class Person
{
    public string Name = "Titiksha";

    public void DisplayPerson()
    {
        Console.WriteLine("Name: " + Name);
    }
}

class Developer : Person
{
    public void DisplayRole()
    {
        Console.WriteLine("Role: .NET Developer");
    }
}

class Program
{
    static void Main()
    {
        Developer developer = new Developer();

        developer.DisplayPerson();
        developer.DisplayRole();
    }
}