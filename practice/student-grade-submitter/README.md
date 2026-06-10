# Student Grade Submitter
**Phase:** Phase 4 — Exception Handling  
A console app that registers multiple students with grade validation, demonstrating custom exceptions, try/catch/finally blocks, and error logging.

## Concepts Practiced
- Custom exceptions (`InvalidStudentNameException`, `InvalidStudentGradeException`)
- try/catch/finally with multiple catch blocks
- Catch-all `Exception` handler
- Error log accumulation and display
- Input validation with `decimal.TryParse` and `int.TryParse`

## Highlights
- Registers multiple students in a single session
- Each failed attempt is logged with exception type and message
- Finally block confirms every attempt regardless of outcome
- Students and error logs printed separately after each iteration

## Rules Enforced
- 0 warnings
- One file per class
- `private set` throughout
- No unused variables or parameters

---
Part of the [CSharpPractice](https://github.com/dreckieee/csharp) portfolio — built in public daily.