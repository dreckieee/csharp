# Order Processor
**Phase:** Phase 4 — Exception Handling

Processes product orders with custom exception handling — 
demonstrating try/catch/finally in a retail inventory context.

## Concepts Practiced
- Custom exceptions — `InvalidAmountException` and `InsufficientStockException`
- `try/catch/finally` — finally block runs on every attempt regardless of outcome
- Multiple catch blocks — each exception type handled separately
- `decimal` for price values — correct type for monetary data
- State tracking — stock deducted on successful orders, preserved on failed ones

## Highlights
- Four order scenarios — valid, invalid quantity, insufficient stock, valid again
- `finally` proves it runs unconditionally — success or failure
- Stock updates correctly across multiple orders on the same product
- Exception messages include product name and quantity for clear error context

## Rules Enforced
- 0 warnings
- One file per class
- `private set` on all mutable properties
- No unused variables or parameters
- End-of-method and end-of-class comments

---
Part of the [CSharpPractice](https://github.com/dreckieee/csharp) portfolio — built in public daily.