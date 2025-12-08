using System;

public abstract class Activity
{
    private string _date;
    private double _lengthInMinutes;

    public Activity(string date, double lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }

    public string Date { get { return _date; } }
    public double LengthInMinutes { get { return _lengthInMinutes; } }

    public abstract double GetDistance(); // km ou milhas
    public abstract double GetSpeed(); // kph ou mph
    public abstract double GetPace(); // min por km ou min por milha

    public virtual string GetSummary()
    {
        return $"{Date} {this.GetType().Name} ({LengthInMinutes} min) - Distance {GetDistance():0.0}, Speed {GetSpeed():0.0}, Pace: {GetPace():0.00} min per unit";
    }
}
