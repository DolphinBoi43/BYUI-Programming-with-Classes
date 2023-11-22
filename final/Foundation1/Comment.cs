public class Comment
{
    public string _title;
    private string _user, _ucomment;
    public Comment (title, user, ucomment)
    {
        _title = title;
        _user = user;
        _ucomment = ucomment;
    }
    
    public (string, string, string) NewComment()
    {
        return (_title, _user, _ucomment);
    }
    public void DisplayComment()
    {
        Console.WriteLine($"{_user} : {_ucomment}");
    }
}