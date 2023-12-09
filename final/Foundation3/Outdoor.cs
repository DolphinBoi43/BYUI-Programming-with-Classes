public class Outdoor : Event
{
    private string _weather;
    public Outdoor (string title, string details, string date, string time, string address, string weather) : base(title, details, date, time, address)
    {
        _weather = weather;
    }
    public string Full()
    {
        string standard = Standard();
        return $"Event Type: Outdoor\nForecast: {_weather}\n{standard}";
    }
    public string Short()
    {
        return $"Event Type: Outdoor\n{_title} {_date}";
    }
}