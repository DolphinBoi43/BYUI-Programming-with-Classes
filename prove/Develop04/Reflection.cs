public class Reflection : Activity
{
    private int _time;
    public Reflection (string activity, int time) : base (activity)
    {
        _time = time;
        // _topics = topics;
    }
    public string ReflectInstuct() // in minutes
    {
        return "For the next " + _time + "minutes, just think back and reflect";
    }
    public void ReflectAnimation(string think1, string think2)
    {
        int wait = 2000;
        // Start of the actual reflecting ativity
        Console.Clear();
        Console.WriteLine(topic);
        WriteAt("(=_=)", 0, 1);
        for (int i = 0; i < _time*30; i++) //Should add a thought bubble every 2 secs for however long the session is
        {
            Thread.Sleep(wait);
            for (int i = 0; i < 3; i++) //only do it 3 times
            {
                WriteAt("*", i+5, 1);
                Thread.Sleep(wait);
            }
            WriteAt("   ", i+5, 1);
        }
        Console.Clear();
    }

}