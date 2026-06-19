# GameLeaderboard
**Phase:** Phase 2 — Collections & Lists (LINQ Refresher)
A randomized leaderboard system for 7 players, driven entirely by LINQ queries.

## Concepts Practiced
- OrderByDescending — full leaderboard sorted by score
- Take — top 3 players extracted from sorted list
- MaxBy / MinBy — highest and lowest scorer
- Average — mean score across all players
- FindAll / Where — filter by playtime and wins
- for loop with i+1 replacing external count variable
- Extracted DisplayPlayerInfo() method — DRY enforcement

## Highlights
- All player data randomized on each run via Random
- Every query declared at point of use with a meaningful variable name
- No shared mutable state across unrelated operations

## Rules Enforced
- 0 warnings
- One file per class
- private set throughout
- Always use braces
---
Part of the [CSharpPractice](https://github.com/dreckieee/csharp) portfolio — built in public daily.