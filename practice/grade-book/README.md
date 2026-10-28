# GradeBook

**Phase:** Phase 2 — Collections & Lists

Console app that stores students and their grades by name and reports results through a menu.

## Concepts Practiced

- Dictionary with a case-insensitive key comparer
- TryGetValue (one lookup instead of two)
- IReadOnlyList vs List
- Reference vs value types
- LINQ and deferred execution

## Highlights

- Menu loop for adding students and grades
- Student names are trimmed and matched case-insensitively, so "ana" and " Ana " are the same student
- Grade range (0-100) is enforced by the Student class, not the input reader

## Rules Enforced

- 0 warnings before every push
- One file per class
- `private set` unless exposed writing is needed
- No unused variables or parameters
- No bare `catch (Exception)`

---

Part of the [CSharpPractice](https://github.com/dreckieee/csharp) portfolio — built in public daily.