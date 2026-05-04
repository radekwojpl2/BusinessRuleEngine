using BuisnessRuleEngine.Exceptions;
using BuisnessRuleEngine.Testing.NUnit.Extensions;
using BuissnessRuleEngine;
using NUnit.Framework;

namespace BuisnessRuleEngine.Tests;

class BuisnessGymMustBeClosed : BuisnessRuleSubject<ClimbingGym>, IBuisnessRule
{
    public BuisnessGymMustBeClosed(ClimbingGym testClass) : base(testClass)
    {

    }

    public string Message => "Clibing gym must be closed.";

    public bool IsBroken() => _subject.IsClosed;
}


internal class ClimbingGymBusinessRulesTests
{

    [Test]
    public void ClimbingGymIsClosed_ThrowsException()
    {

        var test = new ClimbingGym(true);

        AssertRule.ThrowsBrokenBuisnessRuleException(new BuisnessGymMustBeClosed(test));
        AssertRule.MessageIsEqual(new BuisnessGymMustBeClosed(test), "Clibing gym must be closed.");

    }

}
