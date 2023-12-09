public class Lecture : Event
{
    private string _speaker, _capacity;
    public Lecture (string title, string details, string date, string time, string address, string speaker, string capacity) : base(title, details, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string Full()
    {
        string standard = Event.Standard();
        return $"Event Type: Lecture\nSpeaker: {_speaker}\nCapacity: {_capacity}\n{standard}";
    }
    public string Short()
    {
        return $"Event Type: Lecture\n{_title} {_date}";
    }
}