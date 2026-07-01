# Inventory Reorder Analyzer
**Phase:** Phase 2 — Collections & LINQ

A retail inventory reorder analysis tool that identifies low stock items,
summarizes inventory by category, and flags the most urgent reorder category.

## Concepts Practiced
- `IEnumerable<T>` as return type for LINQ method results
- `Where` for low stock filtering
- `GroupBy` for category grouping
- `Select` for projecting groups into `CategorySummary` objects
- `Sum`, `Count`, `MaxBy` for aggregate analysis per category
- `ArgumentNullException` and `InvalidOperationException` guards
- `.ToList()` to force evaluation and prevent double LINQ execution
- `nameof()` for refactor-safe exception parameter names
- `decimal` for all monetary values

## Highlights
- 36 inventory items across 3 categories (Beverages, Canned Goods, Junk Foods)
- `ReorderAnalyzer` static class handles all analysis logic separately from data
- `CategorySummary` class holds per-category totals — fully typed, no anonymous types
- `GetMostUrgentCategory` throws `InvalidOperationException` when no items are low stock
- `IInventoryItem` interface keeps the inventory list polymorphic

## Rules Enforced
- Zero warnings
- One file per class
- `private set` on all properties
- No magic numbers — threshold passed as parameter throughout
- Variables declared at point of use
- `decimal` for all prices and totals

---
Part of the [CSharpPractice](https://github.com/dreckieee/csharp) portfolio — built in public daily.