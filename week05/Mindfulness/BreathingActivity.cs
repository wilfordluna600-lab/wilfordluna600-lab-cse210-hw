public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        ;
    }

    public void Run()
    {

        // Index this part I am writing some code first and then
        // I am going to review that it work wery well.

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(base._duration);
        Console.WriteLine();
        Console.Write("Breathe in...");
        ShowCountDown(2);
        Console.Write("Now breathe out...");
        ShowCountDown(3);
        Console.WriteLine();

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            ShowCountDown(4);
            Console.Write("Now breathe out...");
            ShowCountDown(6);
            Console.WriteLine();
        }




    }
}