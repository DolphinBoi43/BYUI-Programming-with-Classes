using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name: ");
        string name = Console.ReadLine();
        return name;    
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number: ");
        int num = int.Parse(Console.ReadLine());
        return num; 
    }
    static int SquareNumber(int usernum)
    {
        int num = usernum * usernum; 
        return num;
    }
    static void DisplayResult(int usernum, string username)
    {
        int square = SquareNumber(usernum);
        Console.WriteLine($"{username}, your number squared is {square}");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        DisplayResult(number, name);

    }
}