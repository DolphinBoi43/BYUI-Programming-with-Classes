public class ProgressGoal : Goal
{
    private double _progress, _goal;
    public ProgressGoal(string goal_name, string goal_description, double progress, double goal ) : base (goal_name, goal_description)
    {
        _progress = progress;
        _goal = goal;
    }
    public override void UpdateGoal()
    {

    }
}