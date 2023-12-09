public class Comment
{
    private string _user, _ucomment;
    public Comment (user, ucomment)
    {
        _user = user;
        _ucomment = ucomment;
    }
    public void DisplayComment()
    {
        Console.WriteLine($"{_user} said '{_ucomment}'");
    }
}