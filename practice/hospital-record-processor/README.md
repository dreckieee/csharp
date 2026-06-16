# HospitalRecordProcessor
**Phase:** Phase 4 — Exception Handling
Batch processes patient records through age and diagnosis validation, routing failures using exception filters and accumulating errors across the full batch.

## Concepts Practiced
- Exception hierarchy — PatientRecordAgeException and PatientRecordDiagnosisException extending PatientRecordException
- `catch (Exception ex) when (condition)` filters on both exception type and property value
- Two independent try blocks per record — both checks always run regardless of individual failures
- Error log accumulation across all records, printed after batch completes
- `finally` block for guaranteed per-record completion output
- Single Responsibility Principle — PatientRecord is data only, PatientRecordValidator detects and throws, Program.cs catches and routes

## Highlights
- Pascual and Zergei both trigger dual errors — invalid age AND flagged diagnosis — both caught and logged independently
- Validator throws only — no catching inside validator, no blurred responsibility boundary
- All six code paths exercised including fallback catches

## Rules Enforced
- Zero warnings
- One file per class
- `private set` throughout
- Always use braces
---
Part of the [CSharpPractice](https://github.com/dreckieee/csharp) portfolio — built in public daily.