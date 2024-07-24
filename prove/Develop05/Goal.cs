using System;

public abstract class Goal
{
    public string _shortName { get; set; }
    public string _description { get; set; }
    public int _points { get; set; }

    public Goal(string name, string description, int points)
{
    _shortName = name;
    _description = description;
    _points = points;
}

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        return $"[ ] {_shortName} - {_description}";
    }
    public abstract string GetStringRepresentation();
}
