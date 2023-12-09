public class Video
{
    private List<Comment> _comments = new List<Comment>();
    private string _title, _author; private float _length; private int _comment_num;
    public Video (title, author, length, comment_num)
    {
        _title = title;
        _author = author;
        _length = length;
        _comment_num = comment_num;
    }
// title / author / length / number of comments
    public void DisplayVideo()
    {
        Console.WriteLine($"{_title} by {_author}\n{_length:.2f} mins || {_comment_num} Comments");
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