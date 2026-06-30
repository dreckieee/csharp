# Inventory Tracker
**Phase:** Phase 3 — OOP & Inheritance

Manages a mixed inventory of physical and digital products through a shared 
interface contract — demonstrating polymorphism and interface implementation in C#.

## Concepts Practiced
- `interface` — defines a shared contract (`IInventoryItem`) for all inventory types
- Polymorphism — `PhysicalProduct` and `DigitalProduct` implement the same interface with different behaviors
- Mixed `List<IInventoryItem>` — one collection, two distinct types
- Custom exceptions — `InvalidAmountException` and `InsufficientStockException`
- `try/catch/finally` — every sell and restock attempt wrapped with guaranteed cleanup
- Sentinel value — `Stock = 1` on `DigitalProduct` signals availability without implying quantity
- `is` type checking — identifies `DigitalProduct` at runtime for restock messaging

## Highlights
- `PhysicalProduct` enforces stock limits — throws `InsufficientStockException` when sell exceeds available stock
- `DigitalProduct` has unlimited sell capacity — tracks `UnitsSold` instead of decrementing stock
- `Restock()` on `DigitalProduct` is a no-op — satisfies interface contract intentionally
- Three inventory snapshots printed — before selling, after selling, after restocking

## Rules Enforced
- 0 warnings
- One file per class
- `private set` on all mutable properties
- No unused variables or parameters
- End-of-method and end-of-class comments

---
Part of the [CSharpPractice](https://github.com/dreckieee/csharp) portfolio — built in public daily.