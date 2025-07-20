class Swimming : Activity
{
    private int _laps;
    public Swimming(string date, float duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }

    public override string GetActivity()
    {
        return "Swimming";
    }

    public override float GetDistance()
    {
        return  (float)(_laps * 0.05);
    }

    public override float GetPace()
    {
        return _duration / GetDistance();
    }

    public override float GetSpeed()
    {
        return 60 / GetPace();
    }
}