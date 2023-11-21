public class SimpleGoal : Goal
{
    private string _goal_check;
    public SimpleGoal(string goal_type, string goal_name, string goal_description, string set_exp, string other) : base (goal_type, goal_name, goal_description, set_exp)
    {
        _goal_check = other;
    }
    public override string NewGoal()
    {
        return _goal_type + ";" + _goal_name + ";" + _goal_description + ";" + _set_exp + ";" + _goal_check;
    }
    public static string UpdateGoal(string Goal)
    {
        char[] seps = {';','+'};
        string[] goal_arr = Goal.Split(seps);
        Console.Write("How much progress did you make?: ");
        string add_num = Console.ReadLine();
        int new_num = int.Parse(goal_arr[4]) + int.Parse(add_num);
        goal_arr[4] = new_num.ToString();
        string updated_goal = goal_arr[0] + ";" + goal_arr[1] + ";" + goal_arr[2] + ";" + goal_arr[3] + ";" + goal_arr[4];
        return updated_goal; 
    }
}