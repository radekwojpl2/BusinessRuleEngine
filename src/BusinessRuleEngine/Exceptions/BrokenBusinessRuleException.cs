namespace BusinessRuleEngine.Exceptions
{
    public class BrokenBusinessRuleException : Exception
    {
        public IBusinessRule Rule { get; }

        public BrokenBusinessRuleException(IBusinessRule rule) : base(rule.Message)
        {
            Rule = rule;
        }
    }
}
