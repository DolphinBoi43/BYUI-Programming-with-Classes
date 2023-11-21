public class ProgressGoal : Goal
{
    private string _progress, _goal;
    public ProgressGoal(string goal_type, string goal_name, string goal_description, string set_exp, string other) : base (goal_type, goal_name, goal_description, set_exp)
    {
        // other >> current_progress + goal
        string[] _other = other.Split("+");
        _progress = _other[0];
        _goal = _other[1];
    }
    public override string NewGoal()
    {
        return _goal_type + ";" + _goal_name + ";" + _goal_description + ";" + _set_exp + ";" + _progress + "+" + _goal;
    }
    public override void UpdateGoal(string goal_name)
    {

    }
    public override int UpdateLevel()
    {
        if (_progress == _goal)
        {
            _exp_earned = int.Parse(_set_exp);
        } else {
            _exp_earned = 0;
        }
        return _exp_earned;
    }
}