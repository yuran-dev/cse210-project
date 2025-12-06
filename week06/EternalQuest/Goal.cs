using System;

public abstract class Goal
{
    // Encapsulation: atributos privados
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    // Abstraction: método abstrato para registrar evento
    public abstract void RecordEvent();

    // Polymorphism: método virtual para detalhes da meta
    public virtual string GetDetailsString()
    {
        return $"{_name} ({_description}) - Points: {_points}";
    }

    // Getter para pontos
    public int GetPoints()
    {
        return _points;
    }
}
