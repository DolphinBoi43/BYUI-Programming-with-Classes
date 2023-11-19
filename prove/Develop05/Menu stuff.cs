using System;
public class Menu
{
    public static void GoalMenu(int Earned_Exp, int Level_Mode)
    {
        Console.WriteLine($"Personal Stats: Level {Earned_Exp / Level_Mode} To Next Level {Earned_Exp % Level_Mode}");
        Console.WriteLine("Main Menu:\n1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Record Event\n6.Quit");
    }
    public static void StartMenu()
    {
        Console.Write("Welcome to the Game Goal Program\n\nLets start accomplishing goals!\n");
        Console.Write("What is your name? : ");
    }
}