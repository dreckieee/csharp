# Dependency Injection Demo
**Phase:** Standalone Drills — Dependency Injection

Standalone console app demonstrating constructor-based dependency injection —
built to close a conceptual gap before applying DI patterns in VapeShopInventoryAPI.

## Concepts Practiced
- Constructor injection — dependency passed in, not created internally
- Interface-based dependency — `OrderProcessor` depends on `ILogger`, not a concrete type
- Manual composition root — `Program.cs` wires dependencies by hand (no DI container)
- Field typing — storing injected dependency as the interface type, not the concrete class

## Highlights
- `ILogger` — custom interface (`Log(string message)`), not the built-in ASP.NET Core one
- `ConsoleLogger` — concrete implementation of `ILogger`
- `OrderProcessor` — consumer that receives `ILogger` via constructor, stays decoupled from `ConsoleLogger`
- Correction cycle: initial version stored the injected dependency as `ConsoleLogger` instead of `ILogger`, re-coupling the class to the concrete type — fixed by typing the field as the interface

## Rules Enforced
- 0 warnings
- One file per class
- `private set` on all mutable properties
- No unused variables or parameters
- End-of-method and end-of-class comments

---
Part of the [CSharpPractice](https://github.com/dreckieee/csharp) portfolio — built in public daily.