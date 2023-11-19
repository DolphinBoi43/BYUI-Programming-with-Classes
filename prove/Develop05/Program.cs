using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        const int Hard = 500;const int Normal = 250; const int Easy = 100;
        string person_save, file_person_save, Save_info, Difficulty, Goal_Type, choice;
        int Earned_Exp = 0; int Level_Mode = 0;
        var run_main = true; var run_goals = true; var run_new_save = false;
        bool new_name = false;
        string _goal_type, _goal_name, _goal_description, _set_exp, _other;
        // First line of file will give us: Difficulty, Earned Exp
        // Format for goals in file is as follows
        // Goal_Type;Goal_name;Goal_details;Set_exp;Other(seperated with '+')    
        List<string> Goal_List = new List<string>(); 
        // string[] Goals = {"Goal Type","Goal Name","Goal Details","Set Exp","Other"};

        // Start of menu boot
        Console.WriteLine("Game Goal Program v0.0.0.0.0.0.0.1");
        Thread.Sleep(2000); Console.Clear();
        while (run_main != false)
        {
            // Load or Create a save file
            Menu.StartMenu();
            person_save = Console.ReadLine();
            file_person_save = person_save + ".txt";
            // Checks for if the user has been here before, and will create a new file if not found
            if (File.Exists(file_person_save) == true)
            {
                Console.Write("\nSave File found - Loading");
                Thread.Sleep(2000);
            }else if (File.Exists(file_person_save) == false)
            {
                Console.Write("\nSave File not found\nWould you like to create a new Save File?\n[y/n]: ");
                string create = Console.ReadLine();
                if (create == "y")
                {
                    File.Create(file_person_save);
                    new_name = true;
                    run_new_save = true;
                }else if(create == "n")
                {
                    Environment.Exit(0);                    
                } 
            } else {
                Console.WriteLine("Error: Cannot compute");
                Thread.Sleep(2000);
                Console.Clear();
            }
            while (run_goals != false)
            {
                // Program either loads a old save file or creates a new one
                Console.Clear();
                if (new_name == false)
                {
                    // First line of file will give us: Difficulty;Earned Exp
                    // Get all info from save file
                    Save_info = File.ReadLines(file_person_save).First();
                    string[] info = Save_info.Split(';');
                    Difficulty = info[0]; Earned_Exp = int.Parse(info[1]);
                    switch (Difficulty.ToLower()) 
                    {
                        case "hard": Level_Mode = Hard;break;
                        case "normal":Level_Mode = Normal;break;
                        case "easy":Level_Mode = Easy;break;
                    }
                    
                    Menu.GoalMenu(Earned_Exp, Level_Mode);
                    choice = Console.ReadLine();
                    Console.Clear();
                    switch (choice)
                    {
                        case "1":
                            Goal_Type = Menu.NewGoalText();
                            switch(Goal_Type)
                            {
                                case "progress": 
                                case "checklist":
                                case "simple":
                                case "eternal":
                                default: break;
                            }
                            break;
                        case "2":
                            break;
                        case "3":
                            break;
                        case "4":
                            break;
                        case "5":
                            break;
                        case "6":
                            break;
                        default:
                            Console.WriteLine("Error: Invalid Selection"); break;
                    }
                // End of a Continued Game Goal 
                }else{


                    // Starts builing a new save file
                    Console.Write("Set Difficulty: Hard, Normal or Easy\n(Hard if you have lots of Goals, Easy if you don't)\n[Enter here]: ");
                    Difficulty = Console.ReadLine();
                    Console.Clear();
                    // Sets Difficulty for the new save file 
                    switch(Difficulty.ToLower())
                    {
                        case "hard": Level_Mode = Hard; Console.WriteLine($"Setting Difficulty to [{Difficulty.ToUpper()}]"); break;
                        case "normal": Level_Mode = Normal; Console.WriteLine($"Setting Difficulty to [{Difficulty.ToUpper()}]"); break;
                        case "easy": Level_Mode = Easy; Console.WriteLine($"Setting Difficulty to [{Difficulty.ToUpper()}]"); break;
                        default: Level_Mode = Easy; Console.WriteLine("Error: Setting Difficulty to [EASY]"); break;
                    }
                    // Starts building a new save file
                    while (run_new_save != false)
                    {
                        Menu.GoalMenu(Earned_Exp, Level_Mode);
                        choice = Console.ReadLine();
                        Console.Clear();
                        switch (choice)
                        {
                            case "1":
                                Goal_Type = Menu.NewGoalText();
                                switch(Goal_Type)
                                {
                                    case "progress":
                                        (_goal_type, _goal_name, _goal_description, _set_exp, _other) = Menu.NewProgressGoal();
                                        ProgressGoal new_Progress_Goal = new ProgressGoal(_goal_type, _goal_name, _goal_description, _set_exp, _other);
                                        Goal_List.Add(new_Progress_Goal.NewGoal());
                                        break;
                                    case "checklist":
                                    case "simple":
                                    case "eternal":
                                    default: break;
                                }
                                break;
                            case "2":
                                foreach (string goal in Goal_List)
                                {
                                    Console.Write($"{goal}");
                                }
                                break;
                            case "3":
                                break;
                            case "4":
                                break;
                            case "5":
                                break;
                            case "6":
                                break;
                            default:
                                Console.WriteLine("Error: Invalid Selection"); break;

                        }
                    }
                // End of New Game Goal
                }
            }
        }
        // Saves the changes after exiting
    }
}