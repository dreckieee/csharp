# Typed Storage
**Phase:** Phase 2 — Collections & Lists (Generics Drill)
A generic storage class that works with any reference type — demonstrated across string, Player, and Product.

## Concepts Practiced
- Generic class with type parameter T
- where T : class constraint for nullable reference type safety
- Predicate<T> for flexible item lookup via Find()
- GetAll() returns a copy of internal storage — encapsulation enforced
- Remove() by reference instead of index

## Highlights
- Same TypedStorage<T> class works across string, Player, and Product with zero code duplication
- Get() returns T? — caller is responsible for null check before use
- Discovered mid-build that returning _storage directly breaks encapsulation — fixed with new List<T>(_storage)

## Rules Enforced
- 0 warnings
- One file per class
- private set throughout
- Always use braces
---
Part of the [CSharpPractice](https://github.com/dreckieee/csharp) portfolio — built in public daily.