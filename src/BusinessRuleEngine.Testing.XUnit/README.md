# BusinessRuleEngine.Testing.XUnit

xUnit testing extensions for [RadekDev.BusinessRuleEngine](https://www.nuget.org/packages/RadekDev.BusinessRuleEngine).

## Installation

```
dotnet add package RadekDev.BusinessRuleEngine.Testing.XUnit
```

## Usage

```csharp
// Assert that a rule is broken (throws BrokenBusinessRuleException)
AssertRule.ThrowsBrokenBusinessRuleException(new ClimbingGymMustBeOpen(climbingGym));

// Assert that a rule is broken and the message matches
AssertRule.MessageIsEqual(new ClimbingGymMustBeOpen(climbingGym), "Climbing gym must be open.");
```
