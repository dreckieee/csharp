# Patient Vitals Monitor

**Phase:** Phase 1 — Fundamentals

Console app simulating a hospital vitals monitoring system. Methods capstone combining out, ref, overloading, and optional parameters.

## Concepts Practiced

- out parameters
- ref parameters
- Method overloading
- Optional parameters

## Highlights

- GenerateVitals() uses out parameters to produce randomized BP and HR readings
- EvaluateStatus() writes a condition rank (Healthy/Stable/Unstable/Critical) into an out parameter
- AdministerMeds() uses ref with optional defaults to adjust vitals toward healthy ranges
- RecordVitals() is overloaded three ways to print vitals with or without units and string values

## Rules Enforced

- 0 warnings before every push
- One file per class
- `private set` unless exposed writing is needed
- No unused variables or parameters

---

Part of the [CSharpPractice](https://github.com/dreckieee/csharp) portfolio — 39 console apps built in public.
