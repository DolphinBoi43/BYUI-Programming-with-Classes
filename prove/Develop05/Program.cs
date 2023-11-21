using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        const int Hard = 500; const int Normal = 250; const int Easy = 100;
        string person_save, file_person_save, Goal_Type, choice;
        string Difficulty = null;
        int Earned_Exp = 0; int Level_Mode = 0;
        var run_main = true; var run_goals = true; var new_save = false;
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
                    File.Create(file_person_save).Close();
                    new_save = true;
                }else if(create == "n")
                {
                    Environment.Exit(0);                    
                } 
            } else {
                Console.WriteLine("Error: Cannot compute");
                Thread.Sleep(2000);
                Console.Clear();
            }
            Console.Clear();
            // Program either loads a old save file or creates a new one
            if (new_save == false)
            {
                // Loads data from previous save file in directory
                StreamReader load_file = new StreamReader(file_person_save);
                string stats = load_file.ReadLine();
                // Gets the person difficulty and earned exp
                string[] stats_Arr = stats.Split(";");
                Difficulty = stats_Arr[0]; Earned_Exp = int.Parse(stats_Arr[1]);
                switch (Difficulty)
                {
                    case "hard": Level_Mode = Hard; break;
                    case "normal": Level_Mode = Normal; break;
                    case "easy": Level_Mode = Easy; break;
                    default: Console.WriteLine("Error Corrupted save"); Environment.Exit(0); break;
                }
                // Gets goals from txt and adds to List for modifying
                string goals;
                while ((goals = load_file.ReadLine()) != null)
                {
                    Goal_List.Add(goals);
                }
                load_file.Close();
            }else if (new_save == true ){
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
                // Writes personal stats to new save file
                using (StreamWriter save_File = new StreamWriter(file_person_save, true))
                {
                    save_File.WriteLine(Difficulty + ";0");
                }
            }
            while (run_goals != false)
            {
                // Start of the goal setting and modifying menu
                Menu.GoalMenu(Earned_Exp, Level_Mode);
                choice = Console.ReadLine();
                Console.Clear();
                switch (choice)
                {
                    // Makes new goals
                    case "1":
                        Goal_Type = Menu.NewGoalText();
                        switch(Goal_Type)
                        {
                            case "progress":
                                (_goal_type, _goal_name, _goal_description, _set_exp, _other) = Menu.NewProgressGoal();
                                ProgressGoal new_Progress_Goal = new ProgressGoal(_goal_type, _goal_name, _goal_description, _set_exp, _other);
                                Goal_List.Add(new_Progress_Goal.NewGoal());
                                break;
                            case "checkpoint":
                                (_goal_type, _goal_name, _goal_description, _set_exp, _other) = Menu.NewCheckPointGoal();
                                CheckPointGoal new_CheckPoint_Goal = new CheckPointGoal(_goal_type, _goal_name, _goal_description, _set_exp, _other);
                                Goal_List.Add(new_CheckPoint_Goal.NewGoal());
                                break;
                            case "simple":
                                (_goal_type, _goal_name, _goal_description, _set_exp, _other) = Menu.NewSimpleGoal();
                                SimpleGoal new_Simple_Goal = new SimpleGoal(_goal_type, _goal_name, _goal_description, _set_exp, _other);
                                Goal_List.Add(new_Simple_Goal.NewGoal());
                                break;
                            case "eternal":
                                (_goal_type, _goal_name, _goal_description, _set_exp, _other) = Menu.NewEternalGoal();
                                EternalGoal new_Eternal_Goal = new EternalGoal(_goal_type, _goal_name, _goal_description, _set_exp, _other);
                                Goal_List.Add(new_Eternal_Goal.NewGoal());
                                break;
                            default: break;
                        }
                        Console.Clear();
                        break;
                    case "2":
                        // Displays Goals by type
                        Goal_List.Sort();
                        foreach (string goal in Goal_List)
                        {
                            Menu.DisplayGoals(goal);
                        }
                        Console.Write("[Press Enter to Continue]");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "3":
                        // Saves current data to goal list
                        Console.WriteLine("Saving...");
                        Goal_List.Sort();
                        File.WriteAllText(file_person_save,string.Empty);
                        using (StreamWriter save_File = new StreamWriter(file_person_save))
                        {
                            save_File.WriteLine(Difficulty + ";" + Earned_Exp);
                            foreach (string goal in Goal_List)
                            {
                                save_File.WriteLine(goal);
                            }
                        }
                        Thread.Sleep(1000);
                        Console.WriteLine("Saved!");
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    case "4":
                        // Updates goal based off name given
                        Console.Write("Name of Goal you want to update: ");
                        string update_goal = Console.ReadLine();
                        Earned_Exp = Menu.UpdateGoal(Goal_List, update_goal, Earned_Exp);
                        break;
                    case "5":
                        // Saves file and then exits loops
                        File.WriteAllText(file_person_save,string.Empty);
                        using (StreamWriter save_File = new StreamWriter(file_person_save))
                        {
                            save_File.WriteLine(Difficulty + ";" + Earned_Exp);
                            foreach (string goal in Goal_List)
                            {
                                save_File.WriteLine(goal);
                            }
                        }
                        run_goals = false;
                        run_main = false;
                        break;
                    default:
                        // Whoopsies
                        Console.WriteLine("Error: Invalid Selection");
                        break;

                }
            }
        }
    }
}