public class ProgressGoal : Goal
{
    private double _progress, _goal; private int _exp_earned;
    public ProgressGoal(string goal_name, string goal_description, int set_exp, double progress, double goal ) : base (goal_name, goal_description, set_exp)
    {
        _progress = progress;
        _goal = goal;
    }
    public override void UpdateGoal()
    {

    }
    public override int UpdateLevel()
    {
        if (_progress == _goal)
        {
            _exp_earned = _set_exp;
        } else {
            _exp_earned = 0;
        }
        return _exp_earned;
    }
}