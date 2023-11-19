public class SimpleGoal : Goal
{
    private string _goal_check; private int _exp_earned;
    public SimpleGoal(string goal_name, string goal_description, int set_exp, string goal_check) : base (goal_name, goal_description, set_exp)
    {
        _goal_check = goal_check;
    }
    public override void UpdateGoal()
    {
        
    }
    public override int UpdateLevel()
    {
        if (_goal_check == "X")
        {
            _exp_earned = _set_exp;
        }else{
            _exp_earned = 0;
        }
        return _exp_earned;
    }
}