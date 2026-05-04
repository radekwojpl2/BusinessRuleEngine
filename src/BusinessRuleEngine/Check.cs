using BusinessRuleEngine.Exceptions;

namespace BusinessRuleEngine;

public static class Check
{
    public static void Rule(IBusinessRule rule)
    {
        if (rule.IsBroken())
        {
            throw new BrokenBusinessRuleException(rule);
        }
    }
}
