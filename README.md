# BusinessRuleEngine

A business rule engine based on https://github.com/kgrzybek/modular-monolith-with-ddd.

[![Release](https://github.com/radekwojpl2/BusinessRuleEngine/actions/workflows/release.yml/badge.svg)](https://github.com/radekwojpl2/BusinessRuleEngine/actions/workflows/release.yml)
[![CI](https://github.com/radekwojpl2/BusinessRuleEngine/actions/workflows/ci.yml/badge.svg)](https://github.com/radekwojpl2/BusinessRuleEngine/actions/workflows/ci.yml)

## Packages

| Package | Description |
|---|---|
| `RadekDev.BusinessRuleEngine` | Core engine |
| `RadekDev.BusinessRuleEngine.Testing.NUnit` | NUnit testing extensions |
| `RadekDev.BusinessRuleEngine.Testing.XUnit` | xUnit testing extensions |

## Installation

```
dotnet add package RadekDev.BusinessRuleEngine
```

## Usage

```csharp
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

## Testing Extensions

### NUnit

```
dotnet add package RadekDev.BusinessRuleEngine.Testing.NUnit
```

```csharp
// Assert that a rule is broken (throws BrokenBusinessRuleException)
AssertRule.ThrowsBrokenBusinessRuleException(new ClimbingGymMustBeOpen(climbingGym));

// Assert that a rule is broken and the message matches
AssertRule.MessageIsEqual(new ClimbingGymMustBeOpen(climbingGym), "Climbing gym must be open.");
```

### xUnit

```
dotnet add package RadekDev.BusinessRuleEngine.Testing.XUnit
```

```csharp
// Assert that a rule is broken (throws BrokenBusinessRuleException)
AssertRule.ThrowsBrokenBusinessRuleException(new ClimbingGymMustBeOpen(climbingGym));

// Assert that a rule is broken and the message matches
AssertRule.MessageIsEqual(new ClimbingGymMustBeOpen(climbingGym), "Climbing gym must be open.");
```
