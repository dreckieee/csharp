# ExceptionFilterDrill
**Phase:** Phase 4 — Exception Handling
Routes support tickets to the correct handler using exception filters (when clause) and a SeverityLevel enum.

## Concepts Practiced
- `catch (Exception ex) when (condition)` syntax
- Multiple when filters on the same exception type
- Filter evaluation order — first match wins, fallback catches the rest
- Enum with explicit integer mapping (Low = 1, Escalated = 2, Critical = 3)
- Custom exception carrying a typed property used by when filters

## Highlights
- Same exception type routed across four distinct catch blocks with zero if/else
- SeverityLevel enum makes invalid severity values impossible at compile time
- Fallback catch handles any unfiltered exception gracefully

## Rules Enforced
- Zero warnings
- One file per class
- `private set` throughout
- Always use braces
---
Part of the [CSharpPractice](https://github.com/dreckieee/csharp) portfolio — built in public daily.