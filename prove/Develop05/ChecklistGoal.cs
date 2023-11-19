public class CheckListGoal : Goal
{
    private int _goal_count, _prog_count;
    public CheckListGoal(string goal_name, string goal_description, int goal_count, int prog_count) : base (goal_name, goal_description)
    {
        _goal_count = goal_count;
        _prog_count = prog_count;

    }
    public override void UpdateGoal()
    {
        
    }

}