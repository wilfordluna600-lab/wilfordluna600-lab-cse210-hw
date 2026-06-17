public class SwimmingActivity : Activity
{

    private float _swimmingLaps;
    public SwimmingActivity(string name, float minutes, float swimmingLaps) : base(name, minutes)
    {
        _swimmingLaps = swimmingLaps;
    }

    public float GetSwimmingLaps()
    {
        return _swimmingLaps;
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