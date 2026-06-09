# Bank System

**Phase:** Phase 4 — Exception Handling

A multi-account banking console app demonstrating exception handling in C# — custom exceptions, try/catch/finally, multiple catch blocks, and the rethrow pattern across a layered system.

## Concepts Practiced

- Custom exceptions inheriting from `Exception`
- Multiple `catch` clauses per `try` block — specific exceptions first, general last
- `finally` blocks for guaranteed execution
- Rethrow pattern — middle layer logs, top layer handles
- `throw;` vs `throw ex;` — preserving the original stack trace
- `StringComparison.OrdinalIgnoreCase` for culture-safe string comparison
- Optional parameters with default values
- Encapsulation — private list accessed only through public methods

## Highlights

- `Bank` class manages a `List<BankAccount>` privately — `FindAccount()`, `ProcessTransaction()`, `PrintAccounts()`, and `Add()` are the only public surface
- `ProcessTransaction()` catches all exceptions, logs them with `[LOG]`, and rethrows — `Program.cs` is responsible for user-facing messages
- `FindAccount()` uses `StringComparison.OrdinalIgnoreCase` for case-insensitive lookup — names stored as uppercase, searched as any case
- `ProcessTransaction()` accepts `receivingAccount` as an optional string parameter — `FindAccount()` resolves it internally so `Program.cs` never touches `BankAccount` objects directly for transfers
- Seven custom exception types covering null input, invalid amount, insufficient funds, account not found, and invalid transaction type
- Nine independent scenarios: valid deposit, invalid deposit, valid withdrawal, overdraft withdrawal, valid transfer, transfer with no receiving account, invalid transaction type, and account not found

## Rules Enforced

- 0 warnings before every push
- One file per class
- `private set` unless exposed writing is needed
- No unused variables or parameters

---

Part of the [CSharpPractice](https://github.com/dreckieee/csharp) portfolio — built in public daily.