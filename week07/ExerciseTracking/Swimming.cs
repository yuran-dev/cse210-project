public class Swimming : Activity
{
    private int _laps;
    private const double lapLengthMeters = 50;

    public Swimming(string date, double lengthInMinutes, int laps)
        : base(date, lengthInMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        // Converte para km
        return (_laps * lapLengthMeters) / 1000;
        // Para milhas: return (_laps * lapLengthMeters / 1000) * 0.62;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / LengthInMinutes) * 60;
    }

    public override double GetPace()
    {
        return LengthInMinutes / GetDistance();
    }
}
