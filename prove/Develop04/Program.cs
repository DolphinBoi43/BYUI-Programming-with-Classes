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
            Console.WriteLine("I choose: ");
            choice = Console.Read();
            switch (choice)
            {
                case "1": Breathing(); break;
                case "2": Console.WriteLine(2); break;
                case "3": Console.WriteLine(3); break;
                case "4": run = false; break;
            }
        }
    }
}