public class CheckListGoal : Goal
{
    private int _goal_count, _bonus_count, _exp_earned;
    public CheckListGoal(string goal_name, string goal_description, int set_exp, int goal_count, int bonus_count) : base (goal_name, goal_description, set_exp)
    {
        _goal_count = goal_count;
        _bonus_count = bonus_count;

    }
    public override void UpdateGoal()
    {
        
    }
    public override int UpdateLevel()
    {
        int check = _goal_count % _bonus_count;
        if (check == 0)
        {
            _exp_earned = _set_exp;
        } else {
            _exp_earned = 0;
        }
        return _exp_earned;
    }

}