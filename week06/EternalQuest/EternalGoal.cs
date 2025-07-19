using System.ComponentModel;

class EternalGoal : Goal
{
    public EternalGoal(string name, string desctiption, int points) : base(name, desctiption, points) { }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName},{_description},{_points}";
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override int RecordEvent()
    {
        return _points;
    }
    public override int UndoEvent()
    {
        return -1* _points;
    }
}