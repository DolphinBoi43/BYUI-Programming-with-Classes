public class EternalGoal : Goal
{
    private string _goal_count;
    public EternalGoal(string goal_type, string goal_name, string goal_description, string set_exp, string other) : base (goal_type, goal_name, goal_description, set_exp)
    {
        _goal_count = other;
    }
    public override string NewGoal()
    {
        return _goal_type + ";" + _goal_name + ";" + _goal_description + ";" + _set_exp + ";" + _goal_count;
    }
    public static string UpdateGoal(string Goal)
    {
        char[] seps = {';','+'};
        string[] goal_arr = Goal.Split(seps);
        Console.Write("Did you do this goal?\n[y/n]: ");
        string goal_check = Console.ReadLine();
        int base_exp = int.Parse(goal_arr[3]); int earned_exp = 0;
        if (goal_check.ToLower() == "y")
        {
            int current_p = int.Parse(goal_arr[4]);
            current_p = current_p + 1;
            earned_exp = base_exp * current_p;
            goal_arr[4] = (current_p).ToString();
            Console.WriteLine($"Well Done!\n{base_exp} EXP earned");
        } else {
            goal_arr[4] = " ";
            Console.WriteLine("I believe in you");
        }
        string updated_goal = goal_arr[0] + ";" + goal_arr[1] + ";" + goal_arr[2] + ";" + goal_arr[3] + ";" + goal_arr[4];
        return updated_goal; 
    }
}