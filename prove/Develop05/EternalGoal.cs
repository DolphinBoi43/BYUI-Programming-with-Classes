public class EternalGoal : Goal
{
    private string _goal_count;
    public EternalGoal(string goal_type, string goal_name, string goal_description, string set_exp, string other) : base (goal_type, goal_name, goal_description, set_exp)
    {
        _goal_count = other;
    }
    public override string NewGoal()
    {
        return _goal_type + ";" + _goal_name + ";" + _goal_description + ";" + _set_exp + ";" + _goal_count;
    }
    public override void UpdateGoal()
    {
        
    }
    public override int UpdateLevel()
    {
        _exp_earned = int.Parse(_goal_count) * int.Parse(_set_exp);
        return _exp_earned; 
    }
}