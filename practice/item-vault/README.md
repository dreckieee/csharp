# Item Vault

**Phase:** Phase 2 — Collections & Lists

Console app with a generic Vault<T> class tested across three independent types.

## Concepts Practiced

- Generics
- List<T>
- Predicate<T>
- Nullable return T?
- Enum

## Highlights

- Vault<T> backed by a List<T> with Add(), Remove(), Find(), and ListAll()
- Find() accepts a Predicate<T> delegate and returns T?
- Tested with Weapon, Potion, and Currency — each overriding ToString() for display
- WeaponType uses enum for type-safe values

## Rules Enforced

- 0 warnings before every push
- One file per class
- `private set` unless exposed writing is needed
- No unused variables or parameters

---

Part of the [CSharpPractice](https://github.com/dreckieee/csharp) portfolio — 39 console apps built in public.
