# Guild Registry

**Phase:** Phase 3 — OOP & Inheritance

Guild management system where Warrior, Mage, and Ranger inherit from an abstract Member class with role-specific rank thresholds.

## Concepts Practiced

- Abstract classes
- protected set
- Find() / FindAll() lambdas
- is pattern matching

## Highlights

- Each subclass overrides Promote() with its own rank threshold logic
- protected set on Rank enforces controlled write access
- is pattern matching accesses subclass-specific stats from a List<Member>

## Rules Enforced

- 0 warnings before every push
- One file per class
- `private set` unless exposed writing is needed
- No unused variables or parameters

---

Part of the [CSharpPractice](https://github.com/dreckieee/csharp) portfolio — built in public daily.
