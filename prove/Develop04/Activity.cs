public class Activity
{
    public string GetReady(string activity_choice)
    {
        return "Alright, get ready to start " + activity_choice;
    }
    public int origRow;
    public int origCol;   
    public void WriteAt(string s, int x, int y)
    { 
    try
        {
        Console.SetCursorPosition(origCol+x, origRow+y);
        Console.Write(s);
        }
    catch (ArgumentOutOfRangeException e)
        {
        Console.Clear();
        Console.WriteLine(e.Message);
        }
    }
        // Create a blank on a line
        // char blank = ' ';
        // int fill = 30;
        // string blank_space = new string (blank, fill);
        // WriteAt(blank_space, 0, 1);
}