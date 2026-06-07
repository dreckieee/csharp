# Combat Calculator

**Phase:** Phase 1 — Fundamentals

Console app that simulates one round of combat using isolated, composable methods.

## Concepts Practiced

- Methods
- Optional parameters
- Math.Clamp()
- Single output point

## Highlights

- RollDamage() generates inclusive random damage in a range
- IsCriticalHit() uses an optional chance parameter with a 20% default
- ApplyDefense() clamps damage reduction so it never goes below 0
- CalculateFinalDamage() orchestrates all three — PrintCombatResult() is the single output point

## Rules Enforced

- 0 warnings before every push
- One file per class
- `private set` unless exposed writing is needed
- No unused variables or parameters

---

Part of the [CSharpPractice](https://github.com/dreckieee/csharp) portfolio — 39 console apps built in public.
