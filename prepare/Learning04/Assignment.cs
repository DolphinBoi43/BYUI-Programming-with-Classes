using System;

public class Assignment
{
    private string _studentName;
    private string _topic;
    public Assignment (string name)
    {
        _studentName = "Sammuel Bennet";
        _topic = "Multiplication";
    }
    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }
}