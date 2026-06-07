# Dialogue Processor

**Phase:** Phase 2 — Collections & Lists

Console app with three string-processing classes: template replacement, banned word filtering, and command parsing.

## Concepts Practiced

- Dictionary<string, string>
- Contains()
- Split()
- Data class

## Highlights

- DialogueTemplate replaces named {placeholders} at runtime using a Dictionary
- DialogueFilter scans input against a banned word list using case-insensitive Contains()
- CommandParser splits raw input via Split(':') into a ParsedCommand data class with Action, Target, and Value

## Rules Enforced

- 0 warnings before every push
- One file per class
- `private set` unless exposed writing is needed
- No unused variables or parameters

---

Part of the [CSharpPractice](https://github.com/dreckieee/csharp) portfolio — 39 console apps built in public.
