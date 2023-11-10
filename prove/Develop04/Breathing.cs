public class Breathing : Activity
{
    private _time;
    public Breathing (string activity, int time) : base (activity)
    {
        _time = time;
    }
    public string BreathInstuct(int time) // in minutes
    {
        return "for the next " + time + "minutes lets just focus on breathing";
    }
    public string BreathCredits(int time)
    {
        return "You have completed your breathing excersize for " + time + "minutes";
    }
    public void BreathAnimation()
    {
        int wait = 1500;
        // Start of the actual breathing ativity
        Console.Clear();
        Console.WriteLine("Breath in...");
        for (int i = 0; i < 3; i++)
        {   
            WriteAt("(^O^)", i*6, 1);
            Thread.Sleep(wait);
        }
        Console.Clear();
        Console.WriteLine("Breath out...");
        for (int i = 0; i < 3; i++)
        {
            WriteAt("(-o-)", i*6, 1);
            Thread.Sleep(wait);
        }
        Console.Clear();
    }
}