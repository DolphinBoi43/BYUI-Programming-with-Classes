using System;
class Program
{
    
    static void Main()
    {
        bool run = true;
        string choice, activity;
        int time;
        Console.Clear();
        Console.WriteLine("Welcome to the Mindfulness Companion App");
        while (run != false)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1) Breathe\n2) List\n3) Reflect\n4) Quit");
            Console.Write("I choose: ");
            choice = Console.ReadLine();
            Console.Write("For how long? (in minutes)");
            time = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case "1": 
                activity = "breathing";
                Breathing brt = new Breathing(activity, time); break;
                case "2": 
                activity = "list";
                Listing lst = new Listing(activity, time); break;
                case "3": 
                activity = "reflect";
                Reflection rft = new Reflection(activity, time); break;
                case "4": run = false; break;
            }
            if (activity = "breathing")
            {

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