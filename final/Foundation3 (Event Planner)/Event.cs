public class Event
{
    private string _title, _details, _date, _time, _address;
    public Event (string title, string details, string date, string time, string address)
    {
        _title = title;
        _details = details;
        _date = date;
        _time = time;
        _address = address;
    }

    public string Standard()
    {
        return $"{_title} @ {_address}\n{_date} {_time}\nDescription:\n{_details}";
    }
}