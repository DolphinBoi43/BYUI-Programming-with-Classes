public class Video
{
    public string _title;
    private string _author; private float _length; private int _comment_num;
    public Video (title, author, length, comment_num)
    {
        _title = title;
        _author = author;
        _length = length;
        _comment_num = comment_num;
    }
    // title / author / length / number of comments
    public (string, string, float, int) NewVideo()
    {

        return (_title, _author, _length, _comment_num); 
    }

    public void DisplayVideo(List<>)
    {
        Console.WriteLine($"{_title} by {_author}\n{_length:.2f} mins || {_comment_num} Comments");
        for (int i = 0; i < _comment_num; i++)
        {
            if 
        }
    }
}