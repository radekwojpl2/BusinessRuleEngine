using BusinessRuleEngine.Exceptions;
using Xunit;

namespace BusinessRuleEngine.Testing.XUnit;

public static class AssertRule
{
    public static void ThrowsBrokenBusinessRuleException(IBusinessRule businessRule)
    {
        Assert.Throws<BrokenBusinessRuleException>(() => Check.Rule(businessRule));
    }

    public static void MessageIsEqual(IBusinessRule businessRule, string message)
    {
        var exception = Assert.Throws<BrokenBusinessRuleException>(() => Check.Rule(businessRule));

        Assert.Equal(message, exception.Message);
    }
}
