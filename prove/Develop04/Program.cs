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
        string activity;
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
                case "1": activity = "Breathing"; break;
                case "2": activity = "Listing"; break;
                case "3": activity = "Reflection"; break;
                case "4": run = false; break;
            }
            act.GetReady(activity);
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