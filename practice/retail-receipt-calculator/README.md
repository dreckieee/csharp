# Retail Receipt Calculator
**Phase:** Standalone Drills — Retail Discount & Receipt Calculator

Standalone console app modeling a retail checkout flow — cart of items, tiered discount
rules, post-discount tax, and a formatted receipt — built as a filler drill adjacent to
the retail domain of VapeShopInventoryAPI, not a piece of that API itself.

## Concepts Practiced
- Multi-class collaboration — `Item`, `ReceiptCalculator`, `Receipt`, `Program` each own a single responsibility
- Tiered conditional logic — discount rate resolved via ordered threshold checks (higher tier first)
- Order-of-operations correctness — discount applied to subtotal, tax applied after discount, not before
- Input validation via guard clauses — invalid `Item` construction fails fast with the correct exception type
- Graceful failure handling — `try`/`catch` in `Program` converts constructor-thrown exceptions into a clean message instead of an unhandled crash

## Highlights
- `Item` — immutable-after-construction (`private set`), validated via a single `GuardItem()` guard clause
- `ReceiptCalculator` — static class, pure calculation only (subtotal, discount tier resolution, tax, final total); no display/formatting logic
- `Receipt` — owns all display/formatting logic (`DisplayReceipt()`), separated from calculation
- Discount tiers — two thresholds, higher-first ordering to avoid an unreachable lower-tier branch

## Rules Enforced
- 0 warnings
- One file per class
- `private set` on all mutable properties
- No magic numbers — discount thresholds/rates and tax rate passed as parameters, not hardcoded inline
- Correct exception type per failure (`ArgumentNullException`, `ArgumentException`)
- `nameof()` for exception parameter names, never hardcoded strings

---
Part of the [CSharpPractice](https://github.com/dreckieee/csharp) portfolio — built in public daily.