public class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base(duration)
    {
        ;
    }

    public void Run()
    {

        // Index this part I am writing some code first and then
        // I am going to review that it work wery well.

        DateTime startTime = new DateTime.Now;
        DateTime endTime = startTime.Add(duration);
        Console.WriteLine();
        Console.Write("Breathe in...");
        ShowCountDown(2);
        Console.Write("Now breathe out...");
        ShowCountDown(3);
        Console.WriteLine();




    }
}