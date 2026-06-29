# Sales Report
**Phase:** Phase 2 — Collections & LINQ

Generates a sales report from a list of sales using LINQ aggregate functions —
mirroring SQL aggregate logic in C#.

## Concepts Practiced
- `Sum()` — total revenue across all sales and per region
- `Average()` — average sale amount
- `MaxBy()` — retrieves the full Sale object with the highest amount
- `MinBy()` — retrieves the full Sale object with the lowest amount
- `GroupBy()` with `Sum()` per group — mirrors SQL GROUP BY with aggregate
- `readonly DateTime CreatedAt` — per-instance timestamp on each sale
- Dynamic reporting — same method called twice on a growing list to show live recalculation

## Highlights
- Report updates accurately as new sales are added to the list
- Regional breakdown shows total revenue per region
- Highest and lowest sale display full record — product, region, amount, timestamp

## Rules Enforced
- 0 warnings
- One file per class
- `private set` on all mutable properties
- No unused variables or parameters
- End-of-method and end-of-class comments

---
Part of the [CSharpPractice](https://github.com/dreckieee/csharp) portfolio — built in public daily.