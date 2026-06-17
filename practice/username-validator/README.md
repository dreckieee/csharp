# UsernameValidator
**Phase:** Phase 4 — Exception Handling
Validates a batch of usernames against length and character rules, collecting all failures into an AggregateException thrown after the full batch is processed.

## Concepts Practiced
- AggregateException as a container for multiple exceptions
- Collecting exceptions into List<Exception> before throwing
- Unpacking InnerExceptions to surface all failures
- Custom exception with a typed property (Username)
- Two independent try blocks per entry — both checks always run

## Highlights
- Invalid entries are never short-circuited — all failures across all usernames are reported
- Custom InvalidUsernameException carries the offending username as a typed property
- Separate validators for length and character rules follow Single Responsibility

## Rules Enforced
- 0 warnings
- One file per class
- Private set on custom exception property
- Static methods called on class directly — no unnecessary instantiation
---
Part of the [CSharpPractice](https://github.com/dreckieee/csharp) portfolio — built in public daily.