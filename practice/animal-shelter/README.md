# Animal Shelter

**Phase:** Phase 3 — OOP & Inheritance

OOP review project. Abstract Animal base class with Dog, Cat, and Parrot. Generic Shelter<T> manages all animals.

## Concepts Practiced

- Abstract classes
- Multiple interfaces
- Generics
- is pattern matching
- Polymorphism

## Highlights

- Dog and Parrot implement IAdoptable and ITrainable — Cat implements IAdoptable only
- Generic Shelter<T> with Add(), Remove(), GetAll(), and Count
- is pattern matching detects interfaces at runtime
- Polymorphism drives MakeSound() across all types via a for loop

## Rules Enforced

- 0 warnings before every push
- One file per class
- `private set` unless exposed writing is needed
- No unused variables or parameters

---

Part of the [CSharpPractice](https://github.com/dreckieee/csharp) portfolio — 39 console apps built in public.
