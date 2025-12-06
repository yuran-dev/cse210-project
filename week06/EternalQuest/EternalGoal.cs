using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Eternal goal recorded! You earned {_points} points.");
        // Nunca completa
    }

    public override string GetDetailsString()
    {
        return $"{_name} ({_description}) - Points per completion: {_points}";
    }
}
