public class EternalGoal : GoalFile
{
    private int _goal_count, _prog_count ,_bonus_check;
    public EternalGoal(string goal_name, string goal_description, int goal_count, int prog_count, int bonus_check) : base (goal_name, goal_description)
    {
        _goal_count = goal_count;
        _prog_count = prog_count;
        _bonus_check = bonus_check;
    }
    public override void UpdateGoal()
    {
        
    }
}