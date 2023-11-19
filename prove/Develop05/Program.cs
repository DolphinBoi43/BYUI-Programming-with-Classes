using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        const int Hard = 5000; const int Normal = 2500; const int Easy = 1000;
        string person_save, file_person_save, Save_info, Difficulty;
        long Earned_Exp;
        var run = true;
        bool new_name = false;
        // First line of file will give us: Difficulty, Earned Exp
        // Format for goals in file is as follows
        // Goal_Type;Goal_name;Goal_details;Set_exp;Other(seperated with '+')    
        List<string> Goal_Type = new List<string>();
        List<string> Goal_name = new List<string>();
        List<string> Goal_details = new List<string>();
        List<int> Set_exp = new List<int>();
        // Will be split up depending on Goal Type
        List<string> Other = new List<string>();

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
                    new_name = true;
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
            if (new_name == false)
            {
                // First line of file will give us: Difficulty;Earned Exp
                // Get all info from save file
                Save_info = File.ReadLines(file_person_save).First();
                string[] info = Save_info.Split(';');
                Difficulty = info[0]; Earned_Exp = int.Parse(info[1]);



            }else{
                // Starts builing a new save file

            }
        }
        // Saves the changes after exiting
    }
}