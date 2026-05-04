using BusinessRuleEngine.Testing.NUnit;

namespace BusinessRuleEngine.Tests.NUnit;

internal class ClimbingGymBusinessRulesTests
{
    [Test]
    public void ClimbingGymIsClosed_WhenRuleIsGymMustBeOpen_ThrowsException()
    {
        var gym = new ClimbingGym(true);

        AssertRule.ThrowsBrokenBusinessRuleException(new ClimbingGymMustBeOpen(gym));
        AssertRule.MessageIsEqual(new ClimbingGymMustBeOpen(gym), "Climbing gym must be open.");
    }
}
