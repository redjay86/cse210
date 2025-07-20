abstract class Activity
{
    private string _date;
    protected float _duration;
    public Activity(string date, float duration)
    {
        _date = date;
        _duration = duration;
    }

    public abstract float GetDistance();
    public abstract float GetSpeed();
    public abstract float GetPace();
    public abstract string GetActivity();
    public string GetSummary()
    {
        return $"{_date} {GetActivity()} ({_duration:F2} min): Distance {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";
    }
}