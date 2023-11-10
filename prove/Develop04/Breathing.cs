public class Breathing : Activity
{
    private int time; // in minutes
    public string BreathInstuct(int time)
    {
        return "for the next " + time + "minutes lets just focus on breathing";
    }
    public void BreathAnimation()
    {
        int wait = 1500;
        // Clear the screen, then save the top and left coordinates.
        Console.Clear();
        origRow = Console.CursorTop;
        origCol = Console.CursorLeft;
        Console.WriteLine("Breath in...")
        // Draw the left side of a 5x5 rectangle, from top to bottom.
        for (int i = 0; i < 3; i++)
        {   
            WriteAt("(^O^)", i*6, 1);
            Thread.Sleep(wait);
        }
        Activity.WriteAt(' '*30, 0, 1);
        // Draw the bottom side, from left to right.
        for (int i = 0; i < 3; i++)
        {
            WriteAt("(-o-)", i*6, 1);
            Thread.Sleep(wait);
        }
    }
}