using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string person_save, file_person_save;
        var run = true;

        // Start of menu boot
        Console.WriteLine("Game Goal Program v0.0.0.0.0.0.0.1");
        Thread.Sleep(2000); Console.Clear();
        // Load or Create a save file
        while (run != false)
        {
            Console.Write("Welcome to the Game Goal Program\n\nLets start accomplishing goals!\n");
            Console.Write("What is your name? : ");
            person_save = Console.ReadLine();
            file_person_save = person_save + ".txt";
            // Checks for if the user has been here before, and will create a new file if not found
            if (File.Exists(file_person_save) == true)
            {
                Console.Write("\nSave File found");
                run = false;
            }else if (File.Exists(file_person_save) == false)
            {
                Console.Write("\nSave File not found\nWould you like to create a new Save File?\n[y/n]: ");
                string create = Console.ReadLine();
                if (create == "y")
                {
                    File.Create(file_person_save);
                    run = false;
                }else if(create == "n")
                {
                    Console.Clear();                    
                } 
            } else
            {
                Console.WriteLine("Error: Cannot compute");
                Thread.Sleep(2000);
                Console.Clear();
            }
        }
        Console.Clear();
        // run = true;
        // while (run != false)
        // {
        //     // Get all info from save file
        //     string saveFile = File.ReadAllLines(filename);
        //     string saveList = new List<string>(saveFile);
        // }
        // // Save File here
    }
}