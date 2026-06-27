# ConstReadonlyDemo
**Phase:** Phase 1 — Fundamentals

Demonstrates the difference between `const` and `readonly` in C# through a game configuration and player creation system.

## Concepts Practiced
- `const` — compile-time constant, implicitly static, same value across the entire program
- `readonly` — runtime constant, assigned once per instance in the constructor, unique per object
- `Guid.NewGuid()` for unique per-instance ID generation
- `DateTime.Now` with millisecond formatting to prove per-instance assignment
- `PadRight()` for aligned console output

## Highlights
- `GameConfig` static class holds `const` values shared across the entire program
- `Player` class uses `readonly` fields assigned in the constructor — each instance gets a unique `Id` and `CreatedAt`
- Output proves `readonly` is per-instance: two players created milliseconds apart show different GUIDs and timestamps

## Rules Enforced
- 0 warnings
- One file per class
- `private set` on all mutable properties
- No unused variables or parameters
- End-of-method and end-of-class comments

---
Part of the [CSharpPractice](https://github.com/dreckieee/csharp) portfolio — built in public daily.