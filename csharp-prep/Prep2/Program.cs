using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter grade percentage: ");
        string gradepercent = Console.ReadLine();
        string letter = ("F");
        int passing = 0;
        int grade = int.Parse(gradepercent);

        if (grade >= 90)
        {
            letter = ("A");
        }
        else if (grade >= 80 && grade < 90)
        {
            letter = ("B");
        }
        else if (grade >= 70 && grade < 80)
        {
            letter = ("C");
        }
        else if (grade >= 60 && grade < 70)
        {
            letter = ("D");
        }
        else if (grade < 60)
        {
            letter = ("F");
        }
        if (grade < 70)
        {
            passing = 1;
        }
        Console.Write($"Your grade is {letter}, ");
        if (passing != 1)
        {
            Console.Write("you are passing");
        }
        else
        {
            Console.Write("you are not passing");
        }
    }
}