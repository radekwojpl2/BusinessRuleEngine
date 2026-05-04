namespace BusinessRuleEngine.Tests.NUnit;

class ClimbingGymMustBeOpen : BusinessRuleSubject<ClimbingGym>, IBusinessRule
{
    public ClimbingGymMustBeOpen(ClimbingGym climbingGym) : base(climbingGym) { }

    public string Message => "Climbing gym must be open.";

    public bool IsBroken() => _subject.IsClosed;
}
