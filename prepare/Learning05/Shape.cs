public abstract class Shape
{
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }
    public string GetColor()
    {
        // Random rnd = new Random();
        // string[] _colors = {"yellow", "red", "blue", "green"};
        // _color = _colors[rnd.Next(0,_colors.Length)];
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }
    public abstract double GetArea();
}