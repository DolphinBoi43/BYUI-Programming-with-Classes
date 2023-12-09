using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        This program will measure in metric first 
        
        1 km = 0.621 mile

        Activity: Date | Length
        Cycling: Speed
        Running: Distance
        Swimming: # of Laps
        - 1 lap = 50 meters
        */
        List<Activity> activities = new List<Activity>();
        Cycling cycle = new Cycling("12/7/2023", 40.0, 15.0);
        Running run = new Running("12/8/2023", 60.0, 6.0);
        Swimming swim = new Swimming("12/9/2023", 130.0, 12.0);
        activities.Add(cycle); activities.Add(run); activities.Add(swim);
        
        Console.WriteLine("In Metric\n");
        foreach (var activity in activities)
        {
            Console.WriteLine($"{activity.GetSummaryKm()}\n");
        }

        Console.WriteLine("In American\n");
        foreach (var activity in activities)
        {
            Console.WriteLine($"{activity.GetSummaryMi()}\n");
        }
    }
}