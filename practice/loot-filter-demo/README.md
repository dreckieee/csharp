# Loot Filter Demo

**Phase:** Phase 3 — OOP & Inheritance

Goblin, Orc, and Dragon inherit from an abstract Enemy class and implement ILootable. Orc and Dragon additionally implement IElite.

## Concepts Practiced

- Abstract classes
- Multiple interfaces
- is pattern matching
- List<T> polymorphism

## Highlights

- ILootable enforces loot drops across all enemies
- IElite marks Orc and Dragon — detected at runtime via is pattern matching
- All enemies stored in a List<Enemy> — loot and elite status resolved polymorphically

## Rules Enforced

- 0 warnings before every push
- One file per class
- `private set` unless exposed writing is needed
- No unused variables or parameters

---

Part of the [CSharpPractice](https://github.com/dreckieee/csharp) portfolio — built in public daily.
