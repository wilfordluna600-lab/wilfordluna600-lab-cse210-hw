public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
        _comments = comments;
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public string GetFullInfoVideo()
    {
        return $"Title: {_title}\nAuthor: {_author}\nLength: {_length} seconds\nNumber of Comments: {GetNumberOfComments()}";
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }
}