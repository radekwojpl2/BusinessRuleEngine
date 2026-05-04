namespace BusinessRuleEngine
{
    public abstract class BusinessRuleSubject<TSubject> where TSubject : class
    {
        protected readonly TSubject _subject;

        protected BusinessRuleSubject(TSubject subject)
        {
            _subject = subject;
        }
    }
}
