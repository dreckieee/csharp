# Error Handler

**Phase:** Phase 4 — Exception Handling

A BankAccount console app demonstrating exception handling in C# — custom exceptions, try/catch/finally blocks, and exception chaining through method calls.

## Concepts Practiced

- Custom exceptions inheriting from `Exception`
- `try` / `catch` / `finally` blocks
- Multiple `catch` clauses per `try` block
- Throwing exceptions instead of printing and continuing
- Exception properties — storing extra data on a custom exception
- Independent `try` blocks so one failure doesn't stop subsequent operations

## Highlights

- `InvalidAmountException` and `InsufficientFundsException` inherit from `Exception` and pass messages via `: base(message)`
- `InsufficientFundsException` stores the attempted `Amount` as a property for richer error output
- `BankAccount.Transfer()` calls `Withdraw()` and `Deposit()` internally — no duplicate validation
- `finally` prints account balances regardless of whether the operation succeeded or threw
- Six independent scenarios: valid deposit, invalid deposit, overdraft withdrawal, valid withdrawal, failed transfer, valid transfer

## Rules Enforced

- 0 warnings before every push
- One file per class
- `private set` unless exposed writing is needed
- No unused variables or parameters

---

Part of the [CSharpPractice](https://github.com/dreckieee/csharp) portfolio — built in public daily.