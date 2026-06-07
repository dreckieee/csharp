# RPG Item Shop

**Phase:** Phase 2 — Collections & Lists

Console app with Shop and Player classes each owning a Dictionary for inventory management.

## Concepts Practiced

- Dictionary<string, int>
- ContainsKey()
- Remove()
- KeyValuePair<string, int>

## Highlights

- Shop and Player each own a Dictionary — items to prices and items to quantities
- Buy() and Sell() use ContainsKey(), dictionary[key], and Remove()
- Sell price calculated at 50% using integer division
- foreach with KeyValuePair<string, int> handles display

## Rules Enforced

- 0 warnings before every push
- One file per class
- `private set` unless exposed writing is needed
- No unused variables or parameters

---

Part of the [CSharpPractice](https://github.com/dreckieee/csharp) portfolio — built in public daily.
