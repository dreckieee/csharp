# C# Practice Projects

27 projects built in 31 days covering fundamentals through OOP,
inheritance, polymorphism, abstract class architecture, and collections.

---

## Phase 1 — Fundamentals
Age Calculator, Grade Calculator, Number Analyzer, Dice Roller, Grade Report System, Mini Character Card Generator

## Phase 2 — Collections & Lists
Character Card, Party Manager, Shopping List Manager, Student Registry, Movie Watchlist, Item Inventory, Enemy Spawner, Dialogue Processor, Mini Phonebook, Item Shop

## Phase 3 — OOP & Inheritance
Battle Demo, Squad Battle Demo, Shape Calculator, RPG Class Selector, Turn-Based Battle, Loot Filter Demo, Dragon's Gate, Guild Registry, Potion Shop, Crime Report Demo, Tech Support Ticket

---

## Projects

- **Age Calculator** — Console app that calculates exact age from birthdate using `DateTime`.

- **Grade Calculator** — Console app that averages n subject scores and outputs a final grade using a `for` loop and `decimal` arithmetic.

- **Number Analyzer** — Console app that finds the sum, average, highest, and lowest of n numbers using `arrays`, multiple methods, and full `input validation`.

- **Dice Roller** — Console app that rolls three dice and awards prizes based on scoring tiers using the `Random` class and conditional logic for doubles and triples.

- **Grade Report System** — Console app that calculates the average grade and letter rating for n students with 5 scores each using `2D arrays`, multiple methods, and full input validation.

- **Mini Character Card Generator** — Console app that generates random RPG stats and calculates a power rating with a tier label using `type casting`, `Convert.ToInt32()`, `PadRight()`/`PadLeft()` for column alignment, and `string arrays` for stat labels.

- **Character Card** — A `Character` class with a constructor, properties, and methods — `LevelUp()`, `TakeDamage()`, `IsAlive()` — split across two files.

- **Party Manager** — Console app that manages an RPG party using three classes — `Hero`, `Party`, and `Program`. `Party` encapsulates a `List<Hero>` with `Find()` lambda expressions for search and filtering.

- **Shopping List Manager** — Console app that manages a `List<string>` through a menu-driven loop covering add, remove, display, and clear operations.

- **Student Registry** — Console app that manages a student list with pass/fail filtering using `FindAll()` and a computed property for auto-calculated status.

- **Movie Watchlist** — Console app that manages a movie list with watch status and rating filters using `FindAll()` lambdas and a boolean toggle for watch state.

- **Item Inventory** — Console app that manages an RPG item inventory with quantity tracking. Items auto-remove at zero stock using `FindAll()` and quantity decrement logic.

- **Enemy Spawner** — Console app that simulates an enemy list with a damage system. Enemies auto-remove at zero HP using `FindAll()` filtered by type and HP threshold.

- **Battle Demo** — Console app with a `Boss` inheriting from `Enemy` and overriding `TakeDamage()` to take half damage and trigger a phase change below an HP threshold. Uses `virtual`, `override`, `: base()`, and `is`.

- **Squad Battle Demo** — RPG battle system with `Warrior`, `Mage`, and `Archer` inheriting from an abstract `Unit` class stored in a `List<Unit>`. `Mage` overrides `TakeDamage()` using Mana as a damage shield and implements `IHealable`. `Archer` has a 30% critical hit chance.

- **Shape Calculator** — `Circle`, `Rectangle`, and `Triangle` inherit from an abstract `Shape` class. A single `foreach` loop calls `GetArea()` on each, returning different calculations per type.

- **RPG Class Selector** — `Knight`, `Wizard`, and `Rogue` inherit from an abstract `Hero` class and override `GetStats()`. User input drives class instantiation via a `switch` statement.

- **Turn-Based Battle** — `Swordsman` and `Archer` inherit from an abstract `Fighter` class and override `Attack()` with different damage logic. Turn order is randomized each round inside a `while` loop game loop.

- **Loot Filter Demo** — `Goblin`, `Orc`, and `Dragon` inherit from an abstract `Enemy` class and implement `ILootable`. `Orc` and `Dragon` additionally implement `IElite`. Uses `is` pattern matching to filter loot drops and elite status at runtime across a `List<Enemy>`.

- **Dragon's Gate** — Turn-based RPG battle where `Hero` and `Dragon` inherit from an abstract `Character` class. HP is clamped with `Math.Clamp()` via a private backing field. A `DefenseMultiplier` property using `protected set` reduces incoming damage when the hero defends.

- **Guild Registry** — Guild management system where `Warrior`, `Mage`, and `Ranger` inherit from an abstract `Member` class and override `Promote()` with role-specific rank thresholds. Uses `protected set` on `Rank`, `Find()`/`FindAll()` lambdas, and `is` pattern matching to access subclass-specific stats from a `List<Member>`.

- **Potion Shop** — Potion inventory system with two-tier interface inheritance — `IPremiumPotion : IRegularPotion`. An abstract `Potion` class serves as the shared base. Uses `is` pattern matching to detect premium potions at runtime and `OrderBy()`/`OrderByDescending()` for inventory sorting.

- **Crime Report Demo** — Console app that manages suspects across three roles — `Civilian`, `Criminal`, and `Witness` — all inheriting from an abstract `Suspect` class. `ICriminal` and `IWitness` enforce role-specific methods detected at runtime via `is` pattern matching on a `List<Suspect>`. Uses `enum` for type-safe status values.

- **Tech Support Ticket** — Console app that manages support tickets across three types — `BugReport`, `FeatureRequest`, and `CrashReport` — all inheriting from an abstract `Ticket` class. `IBugReport`, `IFeatureRequest`, and `ICrashReport` enforce type-specific methods detected at runtime via `is` pattern matching on a `List<Ticket>`. Uses `enum` for `TicketPriority` with Low, Medium, and High values.

- **Dialogue Processor** — Console app with three string-processing classes: `DialogueTemplate` replaces named `{placeholders}` at runtime using a `Dictionary<string, string>`, `DialogueFilter` scans input against a banned word list using case-insensitive `Contains()`, and `CommandParser` trims, lowercases, and splits raw input via `Split(':')` into a `ParsedCommand` data class holding `Action`, `Target`, and `Value`.

- **Mini Phonebook** — Console app that looks up contacts by name using a `Dictionary<string, string>`. Uses `ContainsKey()` for direct key lookup, `ToLower()` for case-insensitive search, and first-letter capitalization for display formatting.

- **Item Shop** — Console app that simulates a buy/sell shop system using two classes: `Shop` manages a `Dictionary<string, int>` of item names and prices with `AddItem()`, `RemoveItem()`, `DisplayListing()`, `GetPrice()`, and `DisplayLowerOrEqualPrice()`. `Player` manages a separate `Dictionary<string, int>` for owned items and quantities with `Buy()`, `Sell()`, and `DisplayInventory()`. Uses `ContainsKey()` for existence checks, `dictionary[key]` for direct value access and updates, `Remove()` for key deletion at zero quantity, and `foreach` with `KeyValuePair<string, int>` to iterate over all entries. Sell price is calculated at 50% using integer division.