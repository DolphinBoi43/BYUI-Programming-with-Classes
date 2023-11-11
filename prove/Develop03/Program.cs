using System;
using System.IO;
class Program
{
    static void Intro()
    {
        Console.WriteLine("Welcome to the Scripture Memorizor App v1.0");
        Console.WriteLine("Prepare yourself in 3...");
        Thread.Sleep(2000); Console.Clear();
        Console.WriteLine("2...");
        Thread.Sleep(2000); Console.Clear();
        Console.WriteLine("1...");
    }
    static void Main(string[] args)
    {
        Random rnd = new Random();
        Console.Clear();
        // Intro();
        
        // Find a scripture to memorize
        string[] Files= new string[2];
            Files[0] = "2 Nephi_29_8-10.txt";
            Files[1] = "Ether_12_4.txt";
        string memorizeScript = Files[rnd.Next(0,Files.Length)];
        Reference rf = new Reference(memorizeScript); //Gets the reference
        Scripture sc = new Scripture(memorizeScript); // Gets the actually verses
        int verse_count = rf.GetVerseCount();
        int verse_start = rf.GetVerseStart();
        int verse_end;
        // Might not actually need this
        if (verse_count == 1)
        {
            verse_end = verse_start;
        }else{
            verse_end = rf.GetVerseEnd();
        }

        // Start of actually memorization
        string run = "";
        List<string> scripture = new List<string>();
        for (int i = 0; i < verse_count; i++)
        {
            scripture.Add(sc.GetVerse(i));
        }
        while (run != "quit")
        {
            Console.Clear();
            // Display the scripture and start the memorization process
            Console.WriteLine($"{rf.GetBook()} {rf.GetChapter()}\n");
            for (int i = 0; i < verse_count; i++)
            {
                Console.WriteLine($"{verse_start + i}. {scripture[i]}");
            }
            for (int i = 0; i < verse_count; i++)
            {
                scripture[i] = sc.WordErase(scripture[i]);
            }
            Console.WriteLine("\nPress the [Enter] key to continue or type quit");
            run = Console.ReadLine();
            Console.Clear();
            if (run != "quit")
            {
                Console.WriteLine("Get Ready!");
            }
        }
        Console.WriteLine("Remeber to continue to seek after good things :)");
        Console.WriteLine("Goodbye");
    }
}