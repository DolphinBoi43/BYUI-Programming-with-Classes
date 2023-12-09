public class Comment
{
    
    private string _user, _ucomment;
    public Comment (string user, string ucomment)
    {
        _user = user;
        _ucomment = ucomment;
    }
    public void DisplayComment()
    {
        Console.WriteLine($"{_user} - {_ucomment}");
    }
}