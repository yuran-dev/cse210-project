using System;

public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _targetCount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus)
        : base(name, description, points)
    {
        _timesCompleted = 0;
        _targetCount = targetCount;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        if (_timesCompleted < _targetCount)
        {
            _timesCompleted++;
            Console.WriteLine($"Progress recorded! You earned {_points} points.");
            if (_timesCompleted == _targetCount)
            {
                Console.WriteLine($"Checklist completed! Bonus points: {_bonus}");
            }
        }
        else
        {
            Console.WriteLine("Checklist goal already completed.");
        }
    }

    public override string GetDetailsString()
    {
        string status = _timesCompleted >= _targetCount ? "[X]" : "[ ]";
        return $"{status} {_name} ({_description}) - Completed {_timesCompleted}/{_targetCount} times. Points: {_points}, Bonus: {_bonus}";
    }
}
