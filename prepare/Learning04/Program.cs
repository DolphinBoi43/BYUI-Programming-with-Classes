using System;
class Program
{
    static void Main(string[] args)
    {
        MathAssignment assignment = new MathAssignment ("Sammuel Bennett", "Trigometry", "Section 7.9", "Problems 4-20");
        WritingAssignment assignment1 = new WritingAssignment("Emma Watson", "Fiction", "Why is Water Wet?");
        string info = assignment.GetSummary();
        string math = assignment.GetHomeworkList();
        string info1 = assignment1.GetSummary();
        string write = assignment1.GetWritingInformation();
        Console.WriteLine(info);
        Console.WriteLine(math);
        Console.WriteLine(info1);
        Console.WriteLine(write);
    }
}