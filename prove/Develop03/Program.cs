using System;
using System.IO;
class Program
{
    
    static void LongWait()
    {
        Thread.Sleep(5000);
        Console.Clear();
    }
    static void Wait()
    {
        Thread.Sleep(2000);
        Console.Clear();
    }
    static void Intro()
    {
        Console.WriteLine("Welcome to the Scripture Memorizor App v1.0");
        LongWait();
        Console.WriteLine("Prepare yourself in 3...");
        Wait();
        Console.WriteLine("2..");
        Wait();
        Console.WriteLine("1..");
        Wait();
    }
    static void Main(string[] args)
    {
        Random rnd = new Random();
        Console.Clear();
        Intro();
        
        // Find a scripture to memorize
        string[] Files= new string[2];
            Files[0] = "2 Nephi_29_8-10.txt";
            Files[1] = "Ether_12_4.txt";
        string memorizeScript = Files[rnd.Next(0,Files.Length)];
        Reference rf = new Reference(memorizeScript); //Gets the reference
        Scripture sc = new Scripture(memorizeScript); // Gets the actually verses
        int verse_count = rf.GetVerseCount();
        int verse_start = 0;
        int verse_end = 0;
        if (verse_count == 1)
        {
            verse_start = rf.GetVerseStart();
            verse_end = verse_start;
        }else{
            verse_start = rf.GetVerseStart();
            verse_end = rf.GetVerseEnd();
        }
        // Start of actually memorization
        string run = "";
        while (run != "quit")
        {
            
            // Display the scripture and start the memorization process
            Console.WriteLine($"{rf.GetBook()} {rf.GetChapter()}:{rf.GetVerses()}\n");
            for (int i = 0; i < verse_count; i++)
            {
                Console.WriteLine($"{verse_start + i}. {sc.GetVerse(i)}");
            }
            Thread.Sleep(2000);
            Console.WriteLine("\nPress the [Enter] key to continue or type quit");
            run = Console.ReadLine();
            Console.Clear();
            if (run != "quit")
            {
                Console.WriteLine("Get Ready!");
                LongWait();
            }else{
                Wait();
            }
        }
        Console.WriteLine("Remeber to continue to seek after good things :)");
        LongWait();
        Console.WriteLine("Goodbye");
        LongWait();
    }
}