public abstract class Activity
{
    private string _name;
    private float _distance;
    private float _minutes;

    public Activity(string name, float distance, float minutes)
    {
        _name = name;
        _distance = distance;
        _minutes = minutes;
    }

    public string GetName()
    {
        return _name;
    }

    public float GetDistanceMeters()
    {
        return _distance;
    }

    public float GetMinutes()
    {
        return _minutes;
    }

    public abstract float GetDistance();

    public abstract float GetSpeed();

    public abstract float GetPace();

    public string GetSummary()
    {
        DateTime now = DateTime.Now;
        return $"{now.Day} {now.ToString("MMM")} {now.Year} {GetName()} ({GetMinutes()} min)- Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}