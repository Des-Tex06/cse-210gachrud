class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points)
    : base(name, description, points)
    {
        return;
    }

    public override void RecordEvent()
    {}
    public override bool IsComplete()
    {
        return true;
    }
    public override string GetStringRepresentation()
    {
        return $"[] {_shortName} ({_description})";
    }


}