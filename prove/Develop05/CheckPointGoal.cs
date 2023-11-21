public class CheckPointGoal : Goal
{
    private string _count, _bonus_count;
    public CheckPointGoal(string goal_type, string goal_name, string goal_description, string set_exp, string other) : base (goal_type, goal_name, goal_description, set_exp)
    {
        // other >> count + complete_count
        string[] _other = other.Split("+");
        _count = _other[0];
        _bonus_count = _other[1];

    }
    public override string NewGoal()
    {
        return _goal_type + ";" + _goal_name + ";" + _goal_description + ";" + _set_exp + ";" + _count  + "+" + _bonus_count;
    }
    public static string UpdateGoal(string Goal)
    {
        char[] seps = {';','+'};
        string[] goal_arr = Goal.Split(seps);
        Console.Write("How much progress did you make?: ");
        string add_num = Console.ReadLine();
        int new_num = int.Parse(goal_arr[4]) + int.Parse(add_num);
        goal_arr[4] = new_num.ToString();
        string updated_goal = goal_arr[0] + ";" + goal_arr[1] + ";" + goal_arr[2] + ";" + goal_arr[3] + ";" + goal_arr[4] + "+" + goal_arr[5];
        return updated_goal; 
    }

}