class SimpleGoal : Goal
{
    protected List<Goal> _goals = new List<Goal>();
    public List<Goal> GetGoalsList()
    {
        return _goals;
    }
    public SimpleGoal(string name, string description, string points)
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