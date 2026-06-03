public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;
    // I am still thinking If I'm going to use 
    // this comments variable or not   

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }
}