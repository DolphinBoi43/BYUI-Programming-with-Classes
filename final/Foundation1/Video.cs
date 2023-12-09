public class Video
{
    public List<Comment> _comments = new List<Comment>();
    private string _title, _author; private int _length; private int _comment_num;
    public Video (string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
// title / author / length / number of comments
    public void DisplayVideo()
    {
        TimeSpan time = TimeSpan.FromSeconds(_length);
        _comment_num = _comments.Count;
        Console.WriteLine($"'{_title}' by {_author}\nLength {time.Minutes}:{time.Seconds} || {_comment_num} Comments");
        Console.WriteLine();
        DisplayComments();
    }
    public void DisplayComments()
    {
        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }
}