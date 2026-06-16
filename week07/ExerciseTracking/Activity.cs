public abstract class Activity
{
    private float _distance;
    private float _minutes;

    public abstract float GetDistance();

    public abstract float GetSpeed();

    public abstract float GetPace();

    public abstract float GetSummary();
}