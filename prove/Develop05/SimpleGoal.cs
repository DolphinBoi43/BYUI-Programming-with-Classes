public class SimpleGoal : Goal
{
    private string _goal_check;
    public SimpleGoal(string goal_name, string goal_description, string goal_check) : base (goal_name, goal_description)
    {
        _goal_check = goal_check;
    }
    public override void UpdateGoal()
    {
        
    }
}