# Tech Support Ticket

**Phase:** Phase 3 — OOP & Inheritance

Console app managing support tickets across three types — BugReport, FeatureRequest, and CrashReport — all inheriting from an abstract Ticket class.

## Concepts Practiced

- Abstract classes
- Multiple interfaces
- is pattern matching
- Enum

## Highlights

- IBugReport, IFeatureRequest, and ICrashReport enforce type-specific methods
- Interface detection at runtime via is pattern matching on a List<Ticket>
- TicketPriority enum with Low, Medium, and High values

## Rules Enforced

- 0 warnings before every push
- One file per class
- `private set` unless exposed writing is needed
- No unused variables or parameters

---

Part of the [CSharpPractice](https://github.com/dreckieee/csharp) portfolio — built in public daily.
