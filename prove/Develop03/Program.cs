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
        Console.Clear();
        Intro();
        string run = "";
        while (run != "quit")
        {
            Random rnd = new Random();
            string[] Files= new string[2];
                Files[0] = "2 Nephi_29_8-10.txt";
                Files[1] = "Ether_12_4.txt";
            string memorizeScript = Files[rnd.Next(0,1)];
            Reference scripture = new Reference(memorizeScript);
            Scripture scripture1 = new Scripture(memorizeScript);
            Console.WriteLine($"{scripture.GetBook()} {scripture.GetChapter()}:{scripture.GetVerses()}");
            // Testing
            int verse_count = scripture1.GetVerseCount();
            Console.WriteLine($"{scripture1.GetScriptures(verse_count)} {verse_count}");
            Thread.Sleep(2000);
            Console.WriteLine("Press the [Enter] key to continue or type quit");
            run = Console.ReadLine();
            if (run != "quit")
            {
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