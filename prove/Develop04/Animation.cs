public class Aninmation
{
    public void ClearCurrentConsoleLine()
    {
        int currentLineCursor = Console.CursorTop;
        Console.SetCursorPosition(0, Console.CursorTop);
        Console.Write(new string(' ', Console.WindowWidth)); 
        Console.SetCursorPosition(0, currentLineCursor);
    }
    public void CatBlink()
    {
        int time = 1000;
        Aninmation.ClearCurrentConsoleLine();
        Console.WriteLine("(^w^)");
        Thread.Sleep(time);
        Aninmation.ClearCurrentConsoleLine();
        Console.WriteLine("(-w-)");
        Thread.Sleep(time);    
    }
    int origRow;
    int origCol;

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
    public void BreathAnimation()
    {
        int wait = 1000;
        // Clear the screen, then save the top and left coordinates.
        Console.Clear();
        origRow = Console.CursorTop;
        origCol = Console.CursorLeft;

        // Draw the left side of a 5x5 rectangle, from top to bottom.
        for (int i = 0; i < 20; i + 4)
        {   
            WriteAt("(^O^)", 0, i);
            Thread.Sleep(wait);
        }
        // Draw the bottom side, from left to right.
        for (int i = 0; i < 20; i + 4)
        {
            WriteAt("(-o-)", 1, i);
            Thread.Sleep(wait);
        }
    }
}