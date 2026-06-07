# Ref Parameters Drill

**Phase:** Phase 1 — Fundamentals

Console app demonstrating ref parameters through three methods using the extract → modify → write-back pattern.

## Concepts Practiced

- ref parameters
- Math.Clamp()
- Extract → modify → write-back pattern

## Highlights

- TakeDamage() subtracts damage from HP clamped to 0
- HealHP() adds heal amount clamped to maxHP
- ApplyBuff() adds a buff directly to attack
- Properties cannot be passed as ref — extract → modify → write-back enforced throughout

## Rules Enforced

- 0 warnings before every push
- One file per class
- `private set` unless exposed writing is needed
- No unused variables or parameters

---

Part of the [CSharpPractice](https://github.com/dreckieee/csharp) portfolio — built in public daily.
