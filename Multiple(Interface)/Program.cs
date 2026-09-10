using System;

interface IDeveloper
{
    void WriteCode();
}

interface ITester
{
    void TestCode();
}

class SoftwareEngineer : IDeveloper, ITester
{
    public void WriteCode()
    {
        Console.WriteLine("Writing code.");
    }

    public void TestCode()
    {
        Console.WriteLine("Testing code.");
    }
}

class Program
{
    static void Main()
    {
        SoftwareEngineer engineer = new SoftwareEngineer();

        engineer.WriteCode();
        engineer.TestCode();
    }
}