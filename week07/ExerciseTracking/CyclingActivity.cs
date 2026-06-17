public class CyclingActivity : Activity
{

    public CyclingActivity(string name, float distance, float minutes) : base(name, distance, minutes)
    {
        ;
    }

    public override float GetDistance()
    {
        return base.GetDistanceMeters() / 1000;
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