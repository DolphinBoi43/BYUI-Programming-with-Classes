public class Breathing : Activity
{
    private _time;
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
        int wait = 1500;
        // Start of the actual breathing ativity
        for (int i = 0; i < _time * 20; i++) //Should do the animation for however long the session is
        {
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
}