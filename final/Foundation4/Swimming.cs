public class Swimming : Activity
{
    private double _laps;
    public Swimming (string date, double length, double laps) : base (date, length)
    {
        _laps = laps;
    }
    public override double Distance()
    {
        return _laps * 50 / 1000;
    }
    public override double Speed()
    {
        return (Distance() / Length()) * 60;
    }
    public override double Pace()
    {
        return Length() / Distance();
    }

    public override string ActivityType()
    {
        return "Swimming";
    }
}