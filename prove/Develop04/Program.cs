using System;
class Program
{
    
    static void Main()
    {
        Activity act = new Activity();
        Breathing brt = new Breathing();
        Reflections rft = new Reflections();
        Listing lst = new Listing();
        bool run = true;
        string choice;
        Console.Clear();
        Console.WriteLine("Welcome to the Mindfulness Companion App");
        while (run != false)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1) Breathe\n2) List\n3) Reflect\n4) Quit");
            Console.Write("I choose: ");
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1": brt.BreathAnimation(); break;
                case "2": Console.WriteLine(2); break;
                case "3": Console.WriteLine(3); break;
                case "4": run = false; break;
            }
        }
        Console.Clear();
        Console.Write("Good job. Continue to be mindful");
        for (int i = 0; i < 3; i++)
        {
            Thread.Sleep(3000);
            Console.Write(".");
        }
        Thread.Sleep(3000);
        Console.Clear();
        Console.WriteLine("Goodbye");
    }
}