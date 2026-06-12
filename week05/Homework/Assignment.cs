using System.Runtime.CompilerServices;

public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(String studentName, String topic)
    {
        _studentName = studentName;
        _topic = topic;
    }
    public String GetStudentName()
    {
        return _studentName;
    }
    public void SetStudentName(String studentName)
    {
        _studentName = studentName;
    }
    public String GetTopic()
    {
        return _topic;
    }
    public void SetTopic(String topic)
    {
        _topic = topic;
    }

    public String GetSummary()
    {
        return $"{GetStudentName()} - {GetTopic()}";
    }
}