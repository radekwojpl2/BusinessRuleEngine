namespace BusinessRuleEngine
{
    public abstract class BusinessRuleSubject<TSubject>(TSubject subject)
        where TSubject : class
    {
        protected readonly TSubject _subject = subject;
    }
}
