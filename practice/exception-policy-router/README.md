# ExceptionPolicyRouter
**Phase:** Phase 4 — Exception Handling
Routes IT policy requests to the correct handler using exception type and policy code as dual filtering axes.

## Concepts Practiced
- `catch (Exception ex) when (condition)` syntax on child exception types
- Exception hierarchy — AccessException and QuotaException extending PolicyException
- Dual-axis filtering — exception type and PolicyCode enum value simultaneously
- Enum with explicit integer mapping for policy codes
- `StringComparison.OrdinalIgnoreCase` for robust string matching
- Fallback catch on base exception type for unrecognized requests

## Highlights
- Five distinct request scenarios — all code paths exercised including Unknown fallback
- PolicyCode enum makes invalid codes impossible at compile time
- RequestType enum prevents invalid request types from being passed in

## Rules Enforced
- Zero warnings
- One file per class
- `private set` throughout
- Always use braces
---
Part of the [CSharpPractice](https://github.com/dreckieee/csharp) portfolio — built in public daily.