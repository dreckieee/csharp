# Sale API Demo
**Phase:** Standalone Drills — Blind Recreation Sale API Demo

Standalone console app recreating the `Sale` and `SaleItem` domain classes from memory,
no reference — built as a diagnostic before adding `SalesController`/`SaleItemsController`
to VapeShopInventoryAPI.

## Concepts Practiced
- Aggregate-root pattern — `SaleItem` mutation only through `Sale` (`AddSaleItem`/`RemoveSaleItem`), no self-`Edit()`
- Shared guard clauses — single `GuardClosedSale()` enforced across all mutating methods
- Static fields for instance-counter state — class-level identity assignment without a database
- Unique identification without EF Core — solving duplicate-`ProductId` and cross-aggregate collision problems without an auto-incrementing DB key

## Highlights
- `Sale` — owns `SaleItems` as a private-backed `IReadOnlyCollection<SaleItem>`, exposes `AddSaleItem`, `RemoveSaleItem`, `CloseSale`
- `SaleItem` — snapshot-at-creation `UnitPriceAtSale`, no `Edit()` by design
- `TransactionNumber` — `Sale`-scoped auto-incrementing identifier solving the duplicate-`ProductId` removal problem
- Static `_nextId` counter — stands in for EF Core's identity-column `Sale.Id` assignment in a database-less console context

## Bugs Found & Fixed (the point of the drill)
- Inverted reassignment guard in `AddSaleItem` — original check fired on unassigned items instead of already-assigned ones
- `Sale.Id` never assigned — defeated the reassignment guard entirely; fixed with a `static` counter
- `RemoveSaleItem` didn't clear the removed item's `SaleId` — blocked legitimate re-adding of a removed item
- Cross-sale `TransactionNumber` collision — two different `Sale` instances can produce items with the same `TransactionNumber`; fixed with an explicit `SaleId` ownership guard in `RemoveSaleItem`
- Wrong exception type for lookup failures — `InvalidOperationException` → `KeyNotFoundException`
- Missing minimum-one-item enforcement in `CloseSale()`

## Rules Enforced
- 0 warnings
- One file per class
- `private set` on all mutable properties
- Correct exception type per failure (`ArgumentNullException`, `ArgumentException`, `InvalidOperationException`, `KeyNotFoundException`)
- No unused variables or parameters

---
Part of the [CSharpPractice](https://github.com/dreckieee/csharp) portfolio — built in public daily.