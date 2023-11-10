public class Listing : Activity
{
    private int _time;
    public Listing (string activity, int time, ) : base(activity)
    {
        _time = time;
    }
    public string ListInstuct() // in minutes
    {
        return "For the next " + _time + "minutes lets just on the topics I'll provide";
    }
    private string[] topics
    public void ListAnimation()
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
                WriteAt($"{i}", i+5, 1);
                Thread.Sleep(wait);
            }
            WriteAt("   ", i+5, 1);
        }
        Console.Clear();
    }

}