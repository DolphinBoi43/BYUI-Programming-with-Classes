public class Activity
{
    public string GetReady(string activity_choice)
    {
        return "Alright, get ready to start " + activity_choice;
    }
    private int origRow;
    private int origCol;   
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
}