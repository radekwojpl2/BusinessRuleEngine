# BusinessRuleEngine

A business rule engine based on https://github.com/kgrzybek/modular-monolith-with-ddd.

## Usage
``` C#

// Define your model
class ClimbingGym
{
    public ClimbingGym(bool isClosed)
    {
        IsClosed = isClosed;
    }

    public bool IsClosed { get; }
}

// Define a rule: the gym must be open before performing some action
class ClimbingGymMustBeOpen : BusinessRuleSubject<ClimbingGym>, IBusinessRule
{
    public ClimbingGymMustBeOpen(ClimbingGym climbingGym) : base(climbingGym) { }

    public string Message => "Climbing gym must be open.";

    public bool IsBroken() => _subject.IsClosed;
}

var climbingGym = new ClimbingGym(true);

// Instead of this:
if (climbingGym.IsClosed)
{
    throw new ConflictException("Climbing gym must be open.");
}

// Use this:
Check.Rule(new ClimbingGymMustBeOpen(climbingGym));
```
