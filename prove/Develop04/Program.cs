using System;

class Program
{
    void Clear()
    {
        Console.Clear();
    }
    static void Main(string[] args)
    {
        Clear();
        Console.WriteLine("Welcome to the Mindfulness Companion App");
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("1) Breathe\n2) List\n3) Reflect");
    }
}