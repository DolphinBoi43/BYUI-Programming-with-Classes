public class CheckPointGoal : Goal
{
    private string _count, _bonus_count;
    public CheckPointGoal(string goal_type, string goal_name, string goal_description, string set_exp, string other) : base (goal_type, goal_name, goal_description, set_exp)
    {
        // other >> count + complete_count
        string[] _other = other.Split("+");
        _count = _other[0];
        _bonus_count = _other[1];

    }
    public override string NewGoal()
    {
        return _goal_type + ";" + _goal_name + ";" + _goal_description + ";" + _set_exp + ";" + _count  + "+" + _bonus_count;
    }
    public override void UpdateGoal()
    {
        
    }
    public override int UpdateLevel()
    {
        int check = int.Parse(_count) / int.Parse(_bonus_count);
        _exp_earned = check * int.Parse(_set_exp);
        return _exp_earned;
    }

}