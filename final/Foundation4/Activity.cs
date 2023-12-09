public abstract class Activity
{
    private string _date;
    private double _length; // in minutes

    public Activity (string date, double length)
    {
        _date = date;
        _length = length;
    }
    public double Length()
    {
        return _length;
    }

    public abstract double Distance();
    public abstract double Speed();
    public abstract double Pace();
    public abstract string ActivityType();
    public string GetSummaryKm()
    {
        return $"Date:{_date}\n{ActivityType()} for {_length:0.00} min\nDistance: {Distance():0.00} km\nSpeed: {Speed():0.00} km/h\nPace: {Pace():0.00} min / km";
    }
    public string GetSummaryMi()
    {
        return $"Date:{_date}\n{ActivityType()} for {_length:0.00} min\nDistance: {(Distance() * 0.621):0.00} miles\nSpeed: {(Speed()  * 0.621):0.00} mph\nPace: {(Pace() * 0.621):0.00} min / mile";
    }
}