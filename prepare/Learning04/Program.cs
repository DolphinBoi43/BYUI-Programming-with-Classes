using System;
class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment ("Sammuel Bennett", "Multiplcation");
        string info = assignment.GetSummary();
        Console.WriteLine(info);
    }
}