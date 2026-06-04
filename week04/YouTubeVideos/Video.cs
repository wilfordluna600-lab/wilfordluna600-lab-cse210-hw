public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;
    // I am still thinking If I'm going to use 
    // this comments variable or not   

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
        return $"Title: {_title} Author: {_author} Length: {_length} seconds\nNumber of Comments: {GetNumberOfComments()}";
    }

}