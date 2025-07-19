class SimpleGoal : Goal
{
    bool _isComplete;
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        if (!IsComplete())
        {
            _isComplete = true;
            return _points;
        }
        else
        {
            return 0;
        }
        
    }

    public override int UndoEvent()
    {
        if (IsComplete())
        {
            _isComplete = false;
            return -1 * _points;
        }
        else
        {
            _isComplete = false;
            return 0;
        }
        
    }


    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
    }
}