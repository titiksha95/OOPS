using System;

class Employee
{
    public void Work()
    {
        Console.WriteLine("Employee is working");
    }
}

class Developer : Employee
{
    public void WriteCode()
    {
        Console.WriteLine("Developer writes code");
    }
}

class Manager : Employee
{
    public void ManageTeam()
    {
        Console.WriteLine("Manager manages the team");
    }
}

class Program
{
    static void Main()
    {
        Developer developer = new Developer();
        developer.Work();
        developer.WriteCode();

        Manager manager = new Manager();
        manager.Work();
        manager.ManageTeam();
    }
}