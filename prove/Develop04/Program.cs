using System;
class Program
{
    
    static void Main()
    {
        int counter = 0;
        bool run = true;
        string choice;
        Console.Clear();
        Console.WriteLine("Welcome to the Mindfulness Companion App");
        while (run != false)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1) Breathe\n2) List\n3) Reflect");
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1": Animation.Breathing(); break;
                case "2": Console.WriteLine(2); break;
                case "3": Console.WriteLine(3); break;
                case "4": run = false; break;
            }
            // while (counter < 5)
            // {
                
            //     counter++;
            // }
        }
    }
}