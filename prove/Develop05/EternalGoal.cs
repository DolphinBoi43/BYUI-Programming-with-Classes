public class EternalGoal : Goal
{
    private int _goal_count, _exp_earned;
    public EternalGoal(string goal_name, string goal_description, int set_exp, int goal_count) : base (goal_name, goal_description, set_exp)
    {
        _goal_count = goal_count;
    }
    public override void UpdateGoal()
    {
        
    }
    public override int UpdateLevel()
    {
        _exp_earned = _goal_count * _set_exp;
        return _exp_earned; 
    }
}