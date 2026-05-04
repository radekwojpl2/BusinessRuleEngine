using BusinessRuleEngine.Testing.XUnit;

namespace BusinessRuleEngine.Tests.XUnit;

public class ClimbingGymBusinessRulesXUnitTests
{
    [Fact]
    public void ClimbingGymIsClosed_WhenRuleIsGymMustBeOpen_ThrowsException()
    {
        var gym = new ClimbingGym(true);

        AssertRule.ThrowsBrokenBusinessRuleException(new ClimbingGymMustBeOpen(gym));
    }

    [Fact]
    public void ClimbingGymIsClosed_WhenRuleIsGymMustBeOpen_MessageIsEqual()
    {
        var gym = new ClimbingGym(true);

        AssertRule.MessageIsEqual(new ClimbingGymMustBeOpen(gym), "Climbing gym must be open.");
    }

    [Fact]
    public void ClimbingGymIsOpen_WhenRuleIsGymMustBeOpen_DoesNotThrow()
    {
        var gym = new ClimbingGym(false);

        var exception = Record.Exception(() => Check.Rule(new ClimbingGymMustBeOpen(gym)));

        Assert.Null(exception);
    }
}
