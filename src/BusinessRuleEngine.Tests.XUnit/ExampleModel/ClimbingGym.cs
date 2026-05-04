namespace BusinessRuleEngine.Tests.XUnit;

class ClimbingGym
{
    public ClimbingGym(bool isClosed)
    {
        IsClosed = isClosed;
    }

    public bool IsClosed { get; init; }
}
