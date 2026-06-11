# Student Grade Analyzer
**Phase:** Phase 4 — Exception Handling  
A console app that analyzes a randomized student registry using LINQ and lambda expressions, with custom exception handling guarding every analysis operation.

## Concepts Practiced
- LINQ methods: `FindAll`, `MaxBy`, `MinBy`, `Average`
- Lambda expressions with custom filtering logic
- Custom exception (`EmptyStudentListException`)
- Multiple isolated try/catch/finally blocks
- Empty list guard pattern before every operation

## Highlights
- Randomly generates a student registry with names and grades each run
- Filters passing and failing students via lambda expressions
- Identifies highest and lowest grade students using `MaxBy` and `MinBy`
- Calculates average grade across all students
- Every analysis method protected against empty list scenarios
- Empty registry run confirmed — all exceptions fire correctly

## Rules Enforced
- 0 warnings
- One file per class
- `private set` throughout
- No unused variables or parameters

---
Part of the [CSharpPractice](https://github.com/dreckieee/csharp) portfolio — built in public daily.