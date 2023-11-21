public class ProgressGoal : Goal
{
    private string _progress, _goal;
    public ProgressGoal(string goal_type, string goal_name, string goal_description, string set_exp, string other) : base (goal_type, goal_name, goal_description, set_exp)
    {
        // other >> current_progress + goal
        string[] _other = other.Split("+");
        _progress = _other[0];
        _goal = _other[1];
    }
    public override string NewGoal()
    {
        return _goal_type + ";" + _goal_name + ";" + _goal_description + ";" + _set_exp + ";" + _progress + "+" + _goal;
    }
    // type;name;desciption;set_exp;progress+goal
    public static (string, int) UpdateGoal(string Goal, int Current_Exp)
    {
        char[] seps = {';','+'};
        string[] goal_arr = Goal.Split(seps);
        Console.Write("How much progress did you make?: ");
        string add_num = Console.ReadLine();
        int current_p = int.Parse(goal_arr[4]); int goal = int.Parse(goal_arr[5]); int add_p = int.Parse(add_num);
        int base_exp = int.Parse(goal_arr[3]);
        current_p =  current_p + add_p;
        if (current_p < goal)
        {
            Console.WriteLine("Keep Going!");
        } else if (current_p >= goal){
            Console.WriteLine($"Congrats! You reached your goal!\n\n{base_exp} EXP earned");
        }
        goal_arr[4] = current_p.ToString();
        string updated_goal = goal_arr[0] + ";" + goal_arr[1] + ";" + goal_arr[2] + ";" + goal_arr[3] + ";" + goal_arr[4] + "+" + goal_arr[5];
        Current_Exp = Current_Exp + base_exp;
        return (updated_goal, Current_Exp); 
    }
}