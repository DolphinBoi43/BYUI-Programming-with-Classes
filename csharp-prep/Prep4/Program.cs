using System;
// If using lists, use this
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string num = "1";
        List<int> num_list = new List<int>();
        Console.WriteLine("Please enter numbers until you've had enough [enter 0 to end]");
        do
        {
            Console.Write("Enter number: ");
            num = Console.ReadLine();
            if (num != "0")
            {
                num_list.Add(int.Parse(num));
            }

        } while (num != "0");

        // Stats finding
        num_list.Sort();
        int sum = 0;
        float avg = 0;
        int max = 0;
        int min = 0;
        for (int i = 0; i < num_list.Count(); i++)
        {
            if (max <= num_list[i])
            {
                max = num_list[i];
            }
            sum += num_list[i];
        }
        min = max;
        for (int i = 0; i < num_list.Count(); i++)
        {
            if (num_list[i] > 0 && num_list[i] < min) 
            {
                min = num_list[i];
            }
        }
        avg = (float)sum / (float)num_list.Count();
        // Stats
        Console.WriteLine($"Total: {sum}");
        Console.WriteLine($"Averge: {avg}");
        Console.WriteLine($"Max: {max}");
        Console.WriteLine($"Smallest + number: {min}");
        for (int i = 0; i < num_list.Count(); i++)
        {
            Console.WriteLine(num_list[i]);
        }
    }
}