public class Breathing : Activity
{
    private int _time;
    public Breathing (string activity, int time) : base (activity)
    {
        _time = time;
    }
    public string BreathInstuct() // in minutes
    {
        return "For the next " + _time + "minutes lets just focus on " + _activity +"ing";
    }
    public void Breath()
    {
        int wait = 1000;
        // Start of the actual reflecting ativity
        Console.Clear();
        for (int i = 0; i < _time*3; i++) //Should add a thought bubble every 2 secs for however long the session is
        {
            WriteAt("Breathe In...", 0, 0);
            WriteAt("(^O^)", 0, 1);
            Thread.Sleep(wait);
            for (int j = 0; j < 3; j++) //only do it 3 times
            {
                WriteAt(" C", j+5, 1);
                Thread.Sleep(wait);
            }
            WriteAt("           ", i, 1);
            Console.Clear();
            WriteAt("Breathe Out...", 0, 0);
            WriteAt("(-o-)", 0, 1);
            Thread.Sleep(wait);
            for (int j = 0; j < 3; j++) //only do it 3 times
            {
                WriteAt(" 3", j+5, 1);
                Thread.Sleep(wait);
            }
            WriteAt("           ", i, 1);
        }
        Console.Clear();
    }
}