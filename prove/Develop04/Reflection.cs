public class Reflection : Activity
{
    Random rnd = new Random();
    private int _time;
    public Reflection (string activity, int time) : base (activity)
    {
        _time = time;
        // _topics = topics;
    }
    public string ReflectInstuct() // in minutes
    {
        return "For the next " + _time + "minutes, just think back and " + _activity + " on life";
    }
    private string[] topics = { "When did you give a compliment to someone last?",
                                "When was the last time you appreciated something in nature?",
                                "When did you last sincerely smiled or laugh? What made you?",
                                "Are you using your time wisely? How can you improve?",
                                "What do you think you take for granted?",
                                "What makes you feel upset or unconfortable?",
                                "What do you think it takes to make you happy?"};
    public void Reflect()
    {
        for (int r = 0; r < _time; r++)
        {
            string topic = topics[rnd.Next(0,topics.Length)];
            int wait = 2000;
            // Start of the actual reflecting ativity
            Console.Clear();
            for (int i = 0; i < _time*2; i++) //Should add a thought bubble every 2 secs for however long the session is
            {
                WriteAt(topic, 0, 0);
                WriteAt("(=_=)", 0, 1);
                Thread.Sleep(wait);
                for (int j = 0; j < 3; j++) //only do it 3 times
                {
                    WriteAt("*", j+5, 1);
                    Thread.Sleep(wait);
                }
                WriteAt("           ", i, 1);
            }
            Console.Clear();
        }
    }

}