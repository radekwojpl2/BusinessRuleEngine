namespace BusinessRuleEngine
{
    public interface IBusinessRule
    {
        string Message { get; }

        bool IsBroken();
    }
}
