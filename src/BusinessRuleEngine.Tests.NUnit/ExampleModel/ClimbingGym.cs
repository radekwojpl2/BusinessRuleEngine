namespace BusinessRuleEngine.Tests.NUnit;

class ClimbingGym
{
    public ClimbingGym(bool isClosed)
    {
        IsClosed = isClosed;
    }

    public bool IsClosed { get; init; }
}
