using System;

class Program
{
    static void Main(string[] args)
    {
        Animation.Clear();
        ConsoleSpiner spin = new ConsoleSpiner();
        Console.Write("Working....");
        while (true) 
        {
            spin.Turn();
        }
        Console.WriteLine("Welcome to the Mindfulness Companion App");
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("1) Breathe\n2) List\n3) Reflect");
    }
}