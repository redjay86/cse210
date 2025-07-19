using System.ComponentModel;

abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;
    public Goal(string name, string desctiption, int points)
    {
        _shortName = name;
        _description = desctiption;
        _points = points;
    }

    public string GetName()
    {
        return _shortName;
    }
    public virtual string GetDetailsString()
    {
        string completed;
        if (IsComplete())
        {
            completed = "X";
        }
        else
        {
            completed = " ";
        }
        return $"[{completed}] {_shortName} ({_description})";

    }
    public abstract int RecordEvent();
    public abstract int UndoEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();
}