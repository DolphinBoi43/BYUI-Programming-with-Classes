public class SimpleGoal : Goal
{
    private string _goal_check;
    public SimpleGoal(string goal_type, string goal_name, string goal_description, string set_exp, string other) : base (goal_type, goal_name, goal_description, set_exp)
    {
        _goal_check = other;
    }
    public override string NewGoal()
    {
        return _goal_type + ";" + _goal_name + ";" + _goal_description + ";" + _set_exp + ";" + _goal_check;
    }
    public override void UpdateGoal()
    {
        
    }
    public override int UpdateLevel()
    {
        if (_goal_check == "X")
        {
            _exp_earned = int.Parse(_set_exp);
        }else{
            _exp_earned = 0;
        }
        return _exp_earned;
    }
}