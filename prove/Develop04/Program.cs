using System;
class Program
{
    void clear()
    {
        Console.Clear();
    }
    static void Main(string[] args)
    {
        clear();
        Console.WriteLine("Welcome to the Mindfulness Companion App");
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("1) Breathe\n2) List\n3) Reflect");
    }
}