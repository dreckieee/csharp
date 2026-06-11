# Item Order Processor
**Phase:** Phase 4 — Exception Handling  
A console app that processes a list of raw order strings, demonstrating exception chaining by wrapping a low-level FormatException inside a custom OrderProcessingException.

## Concepts Practiced
- Exception chaining via `innerException`
- Custom exception with two constructors (message-only and message + innerException)
- `int.Parse` inside try/catch to capture the original `FormatException`
- Accessing `ex.InnerException?.Message` to surface the root cause
- try/catch/finally with catch-all fallback

## Highlights
- Valid orders are parsed and confirmed in real time
- First invalid order triggers the chain — outer message and inner message both printed
- Demonstrates the difference between your custom error and C#'s original error

## Rules Enforced
- 0 warnings
- One file per class
- `private set` throughout
- No unused variables or parameters

---
Part of the [CSharpPractice](https://github.com/dreckieee/csharp) portfolio — built in public daily.