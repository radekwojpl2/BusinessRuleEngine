using BusinessRuleEngine.Exceptions;
using BusinessRuleEngine;
using NUnit.Framework;

namespace BusinessRuleEngine.Testing.NUnit;

public static class AssertRule
{
    public static void ThrowsBrokenBusinessRuleException(IBusinessRule businessRule)
    {
        Assert.Throws<BrokenBusinessRuleException>(() => Check.Rule(businessRule));
    }

    public static void MessageIsEqual(IBusinessRule businessRule, string message)
    {
        var exception = Assert.Throws<BrokenBusinessRuleException>(() => Check.Rule(businessRule));

        Assert.That(exception!.Message, Is.EqualTo(message));
    }
}
