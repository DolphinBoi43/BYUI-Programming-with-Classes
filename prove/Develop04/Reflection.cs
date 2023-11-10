public class Reflection : Activity
{
    private int _time, _topics;
    public Reflection (string activity, int time, int topics) : base (activity)
    {
        _time = time;
        _topics = topics;
    }
    public void ReflectAnimation(string think1, string think2)
    {
        int wait = 1500;
        // Start of the actual reflecting ativity
        Console.Clear();
        Console.WriteLine(think1);
        for (int i = 0; i < 3; i++)
        {   
            WriteAt("(^O^)", i*6, 1);
            Thread.Sleep(wait);
        }
        Console.Clear();
        Console.WriteLine(think2);
        for (int i = 0; i < 3; i++)
        {
            WriteAt("(-o-)", i*6, 1);
            Thread.Sleep(wait);
        }
        Console.Clear();
    }

}