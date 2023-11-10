public class Breathing : base Activity
{
    public void BreathAnimation()
    {
        int wait = 1500;
        // Clear the screen, then save the top and left coordinates.
        Console.Clear();
        origRow = Console.CursorTop;
        origCol = Console.CursorLeft;

        // Draw the left side of a 5x5 rectangle, from top to bottom.
        for (int i = 0; i < 3; i++)
        {   
            WriteAt("(^O^)", i*6, 0);
            Thread.Sleep(wait);
        }
        // Draw the bottom side, from left to right.
        for (int i = 0; i < 3; i++)
        {
            WriteAt("(-o-)", i*6, 1);
            Thread.Sleep(wait);
        }
    }
}