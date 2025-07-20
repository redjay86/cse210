class Running : Activity
{
    private float _distance;
    public Running(string date, float dur, float dist) : base(date, dur)
    {
        _distance = dist;
    }
    public override string GetActivity()
    {
        return "Running";
    }

    public override float GetDistance()
    {
        return _distance;
    }

    public override float GetPace()
    {
        return _duration  / _distance;
    }

    public override float GetSpeed()
    {
        return _distance / _duration*60;
    }
}