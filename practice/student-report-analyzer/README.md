# StudentReportAnalyzer
**Phase:** Phase 2 — Collections & Lists (LINQ Refresher)
Generates a batch of students across three subjects with randomized grades and runs LINQ queries to filter, rank, average, and sort results.

## Concepts Practiced
- LINQ: Where, FindAll, MaxBy, Average, OrderByDescending
- Lambda expressions
- Looping over a subject list to eliminate repeated blocks (DRY)
- Random double generation within a bounded range

## Highlights
- 24 students generated dynamically across Math, English, and Science
- Passing filter, top student, average, and descending ranking — all driven by the same subjects list
- No hardcoded per-subject blocks — subject loop handles all queries

## Rules Enforced
- 0 warnings
- One file per class
- No unused variables
- DRY — subject list drives all query loops
---
Part of the [CSharpPractice](https://github.com/dreckieee/csharp) portfolio — built in public daily.