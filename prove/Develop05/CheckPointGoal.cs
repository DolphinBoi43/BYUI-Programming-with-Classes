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
    public static (string, int) UpdateGoal(string Goal, int Current_Exp)
    {
        char[] seps = {';','+'};
        string[] goal_arr = Goal.Split(seps);
        Console.Write("How much progress did you make?: ");
        string add_num = Console.ReadLine();
        int current_p = int.Parse(goal_arr[4]); int bonus_check = int.Parse(goal_arr[5]); int add_p = int.Parse(add_num);
        current_p =  current_p + add_p;
        int base_exp = int.Parse(goal_arr[3]);int earned_exp = 0;
        if (current_p < bonus_check)
        {
            earned_exp = current_p * base_exp; 
        } else if (current_p >= bonus_check){
            earned_exp = ((current_p / bonus_check) * base_exp) * 3 + ((current_p % bonus_check) * base_exp);
        }
        if ((current_p % bonus_check) != 0)
        {
            Console.WriteLine($"Earned a Bonus!\n\n{earned_exp} EXP earned");
        } else {
            Console.WriteLine($"Keep Going!\n\n{earned_exp} EXP earned");
        }
        goal_arr[4] = current_p.ToString();
        string updated_goal = goal_arr[0] + ";" + goal_arr[1] + ";" + goal_arr[2] + ";" + goal_arr[3] + ";" + goal_arr[4] + "+" + goal_arr[5];
        Current_Exp = Current_Exp + earned_exp; 
        return (updated_goal, Current_Exp);
    }

}