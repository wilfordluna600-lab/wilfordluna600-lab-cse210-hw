public class CyclingActivity : Activity
{


    public override float GetDistance()
    {
        return;
    }

    public override float GetSpeed()
    {
        return;
    }

    public override float GetPace()
    {
        return;
    }

    public override string GetSummary()
    {
        DateTime now = DateTime.Now;
        Console.WriteLine($"{now.Day}, {now.ToString("MMM")}, {now.Year}");
        return;
    }
}