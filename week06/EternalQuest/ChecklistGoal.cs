class ChecklistGoal : Goal
{
    int _target;
    int _bonus;
    int _completed;
    public ChecklistGoal(string name, string desctiption, int points, int target, int bonus) : base(name, desctiption, points)
    {
        _target = target;
        _bonus = bonus;
        _completed = 0;
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_target},{_bonus},{_completed}";
    }

    public override bool IsComplete()
    {
        return _completed >= _target;
    }

    public override int RecordEvent()
    {
        if (!IsComplete())
        {
            int score = _points;
            _completed++;
            if (IsComplete()) { score += _bonus; }
            return score;
        }
        else
        {
            return 0;
        }
    }

    public override int UndoEvent()
    {
        if (_completed > 0)
        {
            int score = _points;
            if (IsComplete()) { score += _bonus; }
            _completed--;
            return -1 * score;
        }
        else
        {
            return 0;
        }
    }

    public override string GetDetailsString()
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
        return $"[{completed}] {_shortName} ({_description}) -- (Completed {_completed}/{_target})";
    }
}