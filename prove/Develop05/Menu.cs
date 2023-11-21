using System;
public class Menu
{
    public static void GoalMenu(int Earned_Exp, int Level_Mode)
    {
        int Next_Level_Exp;
        if (Earned_Exp >= Level_Mode)
        {
            Next_Level_Exp = Earned_Exp % Level_Mode;
        } else {
            Next_Level_Exp = Level_Mode - Earned_Exp;
        }
        Console.WriteLine($"Personal Stats: Level {Earned_Exp / Level_Mode}\nTo Next Level {Next_Level_Exp} EXP\n");
        Console.WriteLine("Main Menu:\n1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Record Event\n6. Quit");
    }
    public static void StartMenu()
    {
        Console.Write("Welcome to the Game Goal Program\n\nLets start accomplishing goals!\n");
        Console.Write("What is your name?: ");
    }
    public static string NewGoalText()
    {
        Console.WriteLine("What type of goal do you want to make?\n[Progress]: Earn EXP after completing task (Ex. Run 40 / 100 miles: Completion = 150 EXP)");
        Console.WriteLine("[Checkpoint]: Complete a task a certain amount of times to earn EXP (Ex. Study for 30 mins 5 times: 10 EXP)");
        Console.WriteLine("[Eternal]: Everytime task is complete, earn EXP (Ex. Every 1 compliment given = 5 EXP)");
        Console.WriteLine("[Simple]: Completing Goal earns EXP (Ex. Send Resume to Company = 100 EXP) ");
        Console.Write("Type choice here: ");
        string goal_type = Console.ReadLine();
        return goal_type.ToLower();
    }

    // Following functions return mulitple strings for the NewGoal() overrides in the other classes
    // Goal Type, Goal Name, Goal Description, Set EXP, Other(Progress+Goal)
    public static (string, string, string, string, string) NewProgressGoal()
    {
        string goal_type = "progress";
        string progress = "0";
        Console.Write("Name of Goal: ");
        string goal_name = Console.ReadLine();
        Console.Write("Describe your Goal: ");
        string goal_description = Console.ReadLine();
        Console.Write("Amount to Completion: ");
        string goal = Console.ReadLine();
        Console.Write("Earned EXP after completing: ");
        string set_exp = Console.ReadLine();
        
        return (goal_type, goal_name, goal_description, set_exp, progress + "+" + goal);
    }
    public static (string, string, string, string, string) NewCheckPointGoal()
    {
        string goal_type = "checkpoint";
        string count = "0";
        Console.Write("Name of Goal: ");
        string goal_name = Console.ReadLine();
        Console.Write("Describe your Goal: ");
        string goal_description = Console.ReadLine();
        Console.Write("Bonus happens every __ time: ");
        string bonus_count = Console.ReadLine();
        Console.Write("Earned EXP after completing [bonus is 3x this]: ");
        string set_exp = Console.ReadLine();
        
        return (goal_type, goal_name, goal_description, set_exp, count + "+" + bonus_count);

    }
    public static (string, string, string, string, string) NewSimpleGoal()
    {
        string goal_type = "simple";
        string goal_check = " ";
        Console.Write("Name of Goal: ");
        string goal_name = Console.ReadLine();
        Console.Write("Describe your Goal: ");
        string goal_description = Console.ReadLine();
        Console.Write("Earned EXP after completing: ");
        string set_exp = Console.ReadLine();
        
        return (goal_type, goal_name, goal_description, set_exp, goal_check);
    }
    public static (string, string, string, string, string) NewEternalGoal()
    {
        string goal_type = "eternal";
        string goal_count = "0";
        Console.Write("Name of Goal: ");
        string goal_name = Console.ReadLine();
        Console.Write("Describe your Goal: ");
        string goal_description = Console.ReadLine();
        Console.Write("Earned EXP each time: ");
        string set_exp = Console.ReadLine();
        
        return (goal_type, goal_name, goal_description, set_exp, goal_count);
    }
    // The following is the format of the goals in the txt file
    // DisplayGoals will take in strings and output formatted strings for the console
    // type;name;desciption;set_exp;other(sepereate with +)
    public static void DisplayGoals(string goal)
    {
        char[] seps = {';','+'};
        string[] goal_array = goal.Split(seps);
        if (goal_array.Length > 5)
        {
            Console.WriteLine($"[{goal_array[4]}/{goal_array[5]}] : {goal_array[1]} - {goal_array[2]} ({goal_array[3]} EXP)");
        } else {
            Console.WriteLine($"[{goal_array[4]}] : {goal_array[1]} - {goal_array[2]} ({goal_array[3]} EXP)");
        }
    
    }
    
}