public class Reception : Event
{
    private string _rsvp
    public Reception (string title, string details, string date, string time, string address) : base(title, details, date, time, address)
    {
        _rsvp = "Please email 'rickybobby@hulu.us' to RSVP";
    }
    public string Full()
    {
        string standard = Event.Standard();
        return $"Event Type: Reception\n{standard}\n{_rsvp}";
    }
    public string Short()
    {
        return $"Event Type: Reception\n{_title} {_date}";
    }
}