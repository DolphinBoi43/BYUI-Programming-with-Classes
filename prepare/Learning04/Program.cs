using System;
class Program
{
    static void Main(string[] args)
    {
        MathAssignment assignment = new MathAssignment ("Sammuel Bennett", "Trigometry", "Section 7.9", "Problems 4-20");
        string info = assignment.GetSummary();
        string math = assignment.GetHomeworkList();
        Console.WriteLine(info);
        Console.WriteLine(math);
    }
}