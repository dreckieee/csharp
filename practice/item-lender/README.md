# ItemLender
**Phase:** Phase 3 — OOP & Inheritance

A console app that drills interface contracts in C#. Book and Dvd independently implement ILendable — the caller only interacts with the interface, never the concrete type.

## Concepts Practiced
- Defining an interface with a contract (`ILendable`)
- Multiple classes implementing the same interface independently
- `bool` return types on interface methods to signal operation success or failure
- Storing mixed types in `List<ILendable>` — caller agnostic of concrete type
- Encapsulation via `private set` on all properties

## Highlights
- `CheckOut()` returns `false` if already borrowed — no redundant state mutation
- `ReturnItem()` returns `false` if already available — symmetric logic with `CheckOut()`
- `GetDetails()` prints type-specific output (Book shows title, Dvd adds duration) behind the same interface call
- No manager class, no menus — seed data only, concept stays isolated

## Rules Enforced
- 0 warnings
- One file per class
- `private set` throughout
- Always use braces
- Variables declared at point of use

---
Part of the [CSharpPractice](https://github.com/dreckieee/csharp) portfolio — built in public daily.