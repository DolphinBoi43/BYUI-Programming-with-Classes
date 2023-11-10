public class Reflection : Activity
{
    private int _time;
    public Reflection (string activity, int time) : base (activity)
    {
        _time = time;
        // _topics = topics;
    }
    public void ReflectAnimation(string think1, string think2)
    {
        int wait = 2000;
        // Start of the actual reflecting ativity
        Console.Clear();
        Console.WriteLine(think1);
        WriteAt("(-_-)", 0, 1);
        for (int i = 0; i < _time*30; i++) //Should add a thought bubble every 2 secs for however long the session is
        {
            WriteAt("*", i+5, 1);
            Thread.Sleep(wait);
        }
        Console.Clear();
    }

}