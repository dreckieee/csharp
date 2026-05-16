# C# Practice Projects

My C# learning journey as an aspiring game developer.
20 projects built in 24 days covering fundamentals through OOP,
inheritance, polymorphism, and abstract class architecture.

---

## Phase 1 — Fundamentals
Age Calculator, Grade Calculator, Number Analyzer, Dice Roller, Grade Report System

## Phase 2 — Collections & Lists
Character Card, Party Manager, Shopping List Manager, Student Registry, Movie Watchlist, Item Inventory, Enemy Spawner

## Phase 3 — OOP & Inheritance
Battle Demo, Squad Battle Demo, Shape Calculator, RPG Class Selector, Turn-Based Battle, Loot Filter Demo, Dragon's Gate, Guild Registry

---

## Projects

- **Age Calculator** — Console app that calculates exact age from birthdate using `DateTime`

- **Grade Calculator** — Console app that lets the user decide on how many subjects. The program uses `loop` to ask for user input through each score, calculates the average, and outputs the grade.

- **Number Analyzer** — Console app that sums, averages, and finds the highest and lowest value out of n numbers entered by the user. The program uses `arrays` to store the inputs and `multiple methods` to perform each calculation.

- **Dice Roller** — Console app that rolls three dice, calculates the total score with bonus logic for doubles and triples, and determines the prize based on scoring tiers. Uses the `Random` class and `.Next()` method to simulate dice rolls, and conditional statements to handle scoring and prize logic.

- **Grade Report System** — Console app that calculates and displays the name, average grade, and equivalent letter rating of n number of students with 5 exam scores each. Uses `2D arrays` to store scores, `multiple methods` to separate logic, and full `input validation` on every entry point.

- **Character Card** — Console app that demonstrates core `OOP` concepts using a Character class with `properties`, a `constructor`, and methods. Features DisplayStats(), LevelUp(), TakeDamage(), and IsAlive() to simulate a basic RPG character system across two separate class files.

- **Party Manager** — Console app that manages an RPG party of up to 4 heroes using three separate classes. Features AddHero(), RemoveHero(), LevelUpHero(), DisplayParty(), and DisplayTotalHP() in a Party class that encapsulates a `List<Hero>`. First use of `List<T>`, lambda expressions with `Find()`, and multi-class OOP architecture.

- **Shopping List Manager** — Console app that manages a shopping list using `List<string>`. Features add, remove, display, and clear functions through a menu-driven loop. Focused on practicing `List<T>` operations without class architecture.

- **Student Registry** — Console app that manages a student registry using `List<Student>`. Features add, search, display all, and display passing students (grade >= 75). First use of `FindAll()` for list filtering and computed properties for auto-calculating pass/fail status based on grade.

- **Movie Watchlist** — Console app that manages a movie watchlist using `List<Movie>`. Features add, mark as watched, display all, display unwatched, and display top rated movies (rating >= 8). Uses `FindAll()` with lambda expressions to filter by watch status and rating, and a boolean IsWatched property to toggle watch state.

- **Item Inventory** — Console app that manages an RPG item inventory using `List<Item>`. Features add, use, display all, display by type, and display low stock items (quantity <= 2). Uses `FindAll()` with lambda expressions to filter by type and quantity, and a quantity decrement that automatically removes an item when stock reaches zero.

- **Enemy Spawner** — Console app that simulates an enemy spawner using `List<Enemy>`. Features spawn, attack, display all, display by type, and display critical enemies (HP <= 20). Uses `FindAll()` with lambda expressions to filter by type and HP, and a damage system that automatically removes an enemy from the list when HP reaches zero.

- **Battle Demo** — Console app that demonstrates `inheritance`, `interfaces`, and `method overriding` using a battle system. Features a Boss class that inherits from Enemy, overrides TakeDamage() to resist and take half damage, and triggers a phase change with a special attack when HP drops below a threshold. First use of `virtual`, `override`, `: base()`, and type checking with `is`.

- **Squad Battle Demo** — Console app that demonstrates `polymorphism`, `abstract` classes, `inheritance`, and `interfaces` in an RPG battle system. Warrior, Mage, and Archer all inherit from an abstract Unit class with different attack patterns, stored in a `List<Unit>` where a single loop calls Attack() on each — firing different behavior automatically. Mage overrides TakeDamage() using Mana as a magic shield, implements `IHealable`, and Archer features a 30% critical hit chance for double damage.

- **Shape Calculator** — Console app that demonstrates `polymorphism`, `abstract` classes, and `inheritance` in a shape calculator. Circle, Rectangle, and Triangle all inherit from an abstract Shape class. A single `foreach` loop calls GetArea() on each object — returning different calculations per shape to showcase polymorphism.

- **RPG Class Selector** — Console app where the user names their hero and selects a class via switch statement. Knight, Wizard, and Rogue all inherit from an abstract Hero class and override GetStats() to display their own unique stat block. Demonstrates `polymorphism`, `abstract` classes, `inheritance`, and `switch` statements.

- **Turn-Based Battle** — Console app that demonstrates `polymorphism` using an abstract Fighter class inherited by Swordsman and Archer. Each overrides Attack() with different logic — Swordsman deals consistent flat damage while Archer hits lighter but has a 30% critical hit chance for double damage. Turn order is randomized each round and the battle runs inside a `while` loop until one fighter's HP reaches zero.

- **Loot Filter Demo** — Console app that demonstrates `polymorphism` using an abstract Enemy class inherited by Goblin, Orc, and Dragon. Two interfaces — `ILootable` (all 3) and `IElite` (Orc and Dragon only). Uses `is` pattern matching to filter which enemies drop loot and which receive an elite title at runtime.

- **Dragon's Gate** — Console app that simulates a turn-based RPG battle against a dragon using `abstract classes` and `inheritance`. Hero and Dragon both inherit from an abstract Character class with a backing field that clamps HP between 0 and MaxHP. Features a `DefenseMultiplier` system using `protected set` that reduces incoming damage when the Hero defends, and a game loop with reusable `ReadString()` and `ReadInt()` input validation helpers.

- **Guild Registry** — Console app that manages a guild of Warriors, Mages, and Rangers through a shared abstract Member class. Each role inherits from Member and overrides Promote() with its own rank thresholds — using `protected set` to allow subclasses to write to Rank while blocking outside code. A `List<Member>` holds all roles, with `Find()` and `FindAll()` lambda expressions to search and filter. Uses `is` pattern matching to inspect a base-class reference at runtime and access role-specific stats. Demonstrates `polymorphism`, `inheritance`, `protected set`, `lambda expressions`, and `is` pattern matching.