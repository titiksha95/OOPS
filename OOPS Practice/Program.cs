using System;

class Student
{
    //id and name are data and fields of the class Student
    public int Id;
    public string Name = string.Empty;

    public void Display()  //Display() = behaviour or method
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Name: {Name}");
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student();

        student.Id = 101;
        student.Name = "Titiksha";

        student.Display();
    }
}