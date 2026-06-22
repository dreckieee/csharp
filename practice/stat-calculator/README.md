# StatCalculator
**Phase:** Phase 1 — Fundamentals

A console app that drills method overloading in C#. One class with three `Calculate()` overloads — the compiler resolves the correct version at call time based on argument types.

## Concepts Practiced
- Method overloading — same method name, different parameter signatures
- Compiler-time overload resolution based on argument types
- Integer division trap — `int / int` truncates decimals, fixed by using `double` for accumulation
- Format specifiers — `:n0` for whole numbers, `:N2` for decimals

## Highlights
- `Calculate(int a, int b)` — returns sum as `int`
- `Calculate(double a, double b)` — returns sum as `double`
- `Calculate(int[] values)` — returns average as `double`
- No casting needed — accumulator declared as `double` from the start

## Rules Enforced
- 0 warnings
- One file per class
- Always use braces
- Variables declared at point of use

---
Part of the [CSharpPractice](https://github.com/dreckieee/csharp) portfolio — built in public daily.