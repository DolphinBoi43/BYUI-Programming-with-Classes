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
            Console.Clear(); Thread.Sleep(3000);
            switch (choice)
            {
                case "1": 
                activity = "breath";
                Breathing brt = new Breathing(activity, time); break;
                case "2": 
                activity = "list";
                Listing lst = new Listing(activity, time); break;
                case "3": 
                activity = "reflect";
                Reflection rft = new Reflection(activity, time); break;
                case "4": run = false; break;
            }
            string intro, credits, instruct;
            switch (activity)
            {
                case "breath": 
                intro = brt.GetReady(); credits = brt.Credits(); instruct = brt.BreathInstuct(); break;
                case "list": 
                intro = lst.GetReady(); credits = lst.Credits(); instruct = lst.ListInstuct(); break;
                case "reflect": 
                intro = rft.GetReady(); credits = rft.Credits(); instruct = rft.ReflectInstuct(); break;
            }
            Console.WriteLine(intro);
            Thread.Sleep(2000);
            Console.Clear();
            Thread.Sleep(2000);
            Console.WriteLine(instruct);
            if (activity = "breath")
            {
                brt.Breath();
            }if else(activity = "list")
            {
                lst.List();
            }if else(activity = "reflect")
            {
                rft.Reflect();
            };
            Console.WriteLine(credits);
            Console.Clear();
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