# Quick Battle

**Phase:** Phase 3 — OOP & Inheritance

Turn-based RPG combat demo with Player and Enemy inheriting from an abstract Character base. Generic Inventory<T> manages potion tracking.

## Concepts Practiced

- Abstract classes
- Generics
- Math.Clamp()
- Expression body properties
- GameState enum
- Switch expression

## Highlights

- HP uses a private backing field with Math.Clamp() and an expression body IsAlive property
- Three enemy types override GetUniqueTraitDescription()
- Generic Inventory<T> manages potion tracking
- GameState enum drives the turn loop — switch expression handles random enemy selection

## Rules Enforced

- 0 warnings before every push
- One file per class
- `private set` unless exposed writing is needed
- No unused variables or parameters

---

Part of the [CSharpPractice](https://github.com/dreckieee/csharp) portfolio — 39 console apps built in public.
