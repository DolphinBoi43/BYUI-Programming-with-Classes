public abstract class Goal
{
    private string _goal_description, _goal_name;
    public int _set_exp;
    public Goal (string goal_name, string goal_description, int set_exp)
    {
        _goal_name = goal_name;
        _goal_description = goal_description;
        _set_exp = set_exp;
    }
    public abstract void UpdateGoal();
    public abstract int UpdateLevel();

}