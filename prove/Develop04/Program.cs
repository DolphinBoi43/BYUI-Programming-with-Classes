using System;
class Program
{
    static void Main()
    {
        bool run = true;
        string choice, activity, intro, credits, instruct;
        int time;
        Console.Clear();
        Console.WriteLine("Welcome to the Mindfulness Companion App");
        while (run != false)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1) Breathe\n2) List\n3) Reflect\n4) Quit");
            Console.Write("I choose: ");
            choice = Console.ReadLine();
            if (choice == "4")
            {
                run = false;
            }else{
                Console.Write("For how long? (1 = short, 3 = long): ");
                time = int.Parse(Console.ReadLine());
                Console.Clear(); Thread.Sleep(3000);
                switch (choice)
                {
                    case "1": 
                    activity = "breath";
                    Breathing brt = new Breathing(activity, time);
                    intro = brt.GetReady(); credits = brt.Credits(); instruct = brt.BreathInstuct(); 
                    Console.WriteLine(intro);
                    Thread.Sleep(2000);
                    Console.Clear();
                    Thread.Sleep(2000);
                    Console.WriteLine(instruct);
                    brt.Breath(); Thread.Sleep(5000); Console.WriteLine(credits); Thread.Sleep(5000); break;
                    case "2": 
                    activity = "list";
                    Listing lst = new Listing(activity, time); 
                    intro = lst.GetReady(); credits = lst.Credits(); instruct = lst.ListInstuct();
                    Console.WriteLine(intro);
                    Thread.Sleep(2000);
                    Console.Clear();
                    Thread.Sleep(2000);
                    Console.WriteLine(instruct); 
                    lst.List(); Thread.Sleep(5000); Console.WriteLine(credits); Thread.Sleep(5000); break;
                    case "3": 
                    activity = "reflect";
                    Reflection rft = new Reflection(activity, time); 
                    intro = rft.GetReady(); credits = rft.Credits(); instruct = rft.ReflectInstuct();
                    Console.WriteLine(intro);
                    Thread.Sleep(2000);
                    Console.Clear();
                    Thread.Sleep(2000);
                    Console.WriteLine(instruct);
                    rft.Reflect(); Thread.Sleep(5000); Console.WriteLine(credits); Thread.Sleep(5000); break;
                }
                Console.Clear();
            }
        }
        Console.Clear();
        Console.Write("Good job. Continue to be mindful");
        for (int i = 0; i < 3; i++)
        {
            Thread.Sleep(2000);
            Console.Write(".");
        }
        Thread.Sleep(2000);
        Console.Clear();
        Console.WriteLine("Goodbye");
        Thread.Sleep(2000);
    }
}