using BuisnessRuleEngine.Exceptions;
using BuissnessRuleEngine;
using NUnit.Framework;

namespace BuisnessRuleEngine.Testing.NUnit.Extensions;

public static class AssertRule
{
    public static void ThrowsBrokenBuisnessRuleException(IBuisnessRule buisnessRule)
    {
        Assert.Throws<BrokenBuisnessRuleException>(() => Check.Rule(buisnessRule));
    }

    public static void MessageIsEqual(IBuisnessRule buisnessRule, string message)
    {
        var exception = Assert.Throws<BrokenBuisnessRuleException>(() => Check.Rule(buisnessRule));

        Assert.That(exception.Message, Is.EqualTo(message));

    }
}
