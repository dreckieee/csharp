# File Reader Simulator
**Phase:** Phase 4 — Exception Handling  
A console app that simulates reading lines from a file, demonstrating the rethrow pattern and continue-on-error exception handling.

## Concepts Practiced
- Rethrow pattern — catching, logging, and rethrowing exceptions
- Continue-on-error — catching inside a loop to process all lines before throwing
- Custom exception (`InvalidLineException`)
- Error log accumulation across multiple failures
- try/catch/finally with catch-all fallback

## Highlights
- Prints all file lines before checking
- Catches invalid lines without stopping execution — all lines are checked
- Accumulated error logs printed in finally block
- Single throw after loop summarizes total invalid line count

## Rules Enforced
- 0 warnings
- One file per class
- `private set` throughout
- No unused variables or parameters

---
Part of the [CSharpPractice](https://github.com/dreckieee/csharp) portfolio — built in public daily.