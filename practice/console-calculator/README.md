# Console Calculator

**Phase:** Standalone Drills

Console app that performs basic arithmetic (add, subtract, multiply, divide) with chained operations — each result can feed into the next calculation without restarting.

## Concepts Practiced

- Methods
- Loops (input validation, main menu loop)
- Conditionals
- Exception handling
- Separation of I/O from domain logic

## Highlights

- `Calculator` is a pure computation class — no `Console` calls inside it; all input/output lives in `Program`
- Chaining support: after a successful operation, the previous `Output` becomes the next `Operand1` automatically instead of requiring re-entry
- `Division()` throws `ArgumentException` on divide-by-zero — correct exception type per invalid *value*, not invalid state
- Divide-by-zero leaves calculator state untouched (`Output`/`IsFirstOperation` unchanged) since the throw happens before either is modified — an aborted operation never silently corrupts the next one
- `SetOperands()` centralizes operand-gathering logic in one place instead of duplicating it per operation branch

## Rules Enforced

- 0 warnings before every push
- One file per class
- `private set` unless exposed writing is needed
- `nameof()` for exception parameter names
- No unused variables or parameters

---

Part of the [CSharpPractice](https://github.com/dreckieee/csharp) portfolio — built in public daily.