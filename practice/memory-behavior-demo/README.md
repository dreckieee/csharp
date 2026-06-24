# MemoryBehaviorDemo
**Phase:** Phase 1 — Fundamentals

A console app that isolates value type vs reference type memory behavior in C#. Identical operations on a struct and a class produce visibly different results — proving the difference through output, not just theory.

## Concepts Practiced
- Value types (`struct`) — assignment copies the value, variables are independent
- Reference types (`class`) — assignment copies the address, variables share the same object
- Mutating an assigned variable to observe downstream effects on the original
- `struct` vs `class` declaration — identical syntax, fundamentally different memory behavior

## Highlights
- `PointStruct` and `PointClass` are structurally identical — only the keyword differs
- Mutating `mutateStruct` leaves `sampleStruct` unchanged — independent copy confirmed
- Mutating `mutateClass` changes `sampleClass` — shared reference confirmed
- Output at each stage makes the memory behavior visible and unambiguous

## Rules Enforced
- 0 warnings
- One file per class/struct
- Always use braces
- Variables declared at point of use

---
Part of the [CSharpPractice](https://github.com/dreckieee/csharp) portfolio — built in public daily.