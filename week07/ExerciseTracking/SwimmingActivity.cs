public class SwimmingActivity : Activity
{

    public SwimmingActivity(string name, float distance, float minutes) : base(name, distance, minutes)
    {
        ;
    }

    public float GetSwimmingLaps()
    {
        return base.GetDistanceMeters();
    }

    public override float GetDistance()
    {
        return (GetSwimmingLaps() * 50) / 1000;
    }

    public override float GetSpeed()
    {
        return (GetDistance() / base.GetMinutes()) * 60;
    }

    public override float GetPace()
    {
        return base.GetMinutes() / GetDistance();
    }
}