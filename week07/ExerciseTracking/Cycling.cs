class Cycling : Activity
{
    private float _speed;
    public Cycling(string date, float duration, float speed) : base(date, duration)
    {
        _speed = speed;
    }

    public override string GetActivity()
    {
        return "Cycling";
    }

    public override float GetDistance()
    {
        return _speed * _duration;
    }

    public override float GetPace()
    {
        return 60 / _speed;
    }

    public override float GetSpeed()
    {
        return _speed;
    }
}