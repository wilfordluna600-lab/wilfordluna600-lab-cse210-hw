public class Activity
{
    // I am still thinking about if the variables would be private or
    // protected, I am going to review it more later and maybe change it.
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
        // It's very possible that I am going to modify this constructor
        // later, so I will review it more later.
    }

    public void DisplayStartingMessage()
    {

    }

    public void DisplayEndingMessage()
    {

    }

    public void ShowSpinner(int seconds)
    {

    }

    public void ShowCountDown(int seconds)
    {

    }
}