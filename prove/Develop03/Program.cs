using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        string[] lines = File.ReadAllLines("scriptures.txt");
        foreach (string line in lines)
        {
            Console.WriteLine(lines);
        }
    }
}