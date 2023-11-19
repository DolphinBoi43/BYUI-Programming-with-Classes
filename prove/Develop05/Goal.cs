public abstract class Goal
{
    public string _goal_type, _goal_name, _goal_description, _set_exp;
    public int _exp_earned;
    public Goal (string goal_type, string goal_name, string goal_description, string set_exp)
    {
        _goal_type = goal_type;
        _goal_name = goal_name;
        _goal_description = goal_description;
        _set_exp = set_exp;
    }
    public abstract string NewGoal();
    public abstract void UpdateGoal();
    public abstract int UpdateLevel();

}