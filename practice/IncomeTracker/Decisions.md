# Decisions & Postmortems — IncomeTracker

Practice/scaffolding drill (not portfolio work). This file holds design rationale,
postmortems, and a day-by-day devlog. See [README.md](./README.md) for current status,
stack, and how-to-run.

## Design Decisions

### Sale has no public setters post-construction
`Sale.Amount` and `Sale.Date` use `private set`. Updates go through an explicit
`Update(decimal amount, DateTime date)` method that re-runs the same constructor guard
clauses (`GuardSale`), rather than direct property assignment. This guarantees a `Sale`
can never exist in an invalid state, whether freshly constructed or updated later.

### Validation asymmetry: Sale vs Expense
`Sale` rejects future dates (`date > DateTime.Now` throws `ArgumentException`). `Expense`
does not — prepaid expenses (e.g. rent paid in advance) are a valid business case, so a
future-dated expense is legitimate. This is a deliberate asymmetry, not an inconsistency
to unify.

### ExceptionHandlingMiddleware placement (before UseAuthorization)
**Decision:** `ExceptionHandlingMiddleware` is registered in `Program.cs` before
`app.UseAuthorization()`, so it wraps auth and everything downstream in a single
try/catch boundary.

**Why:** Centralizing exception handling at the top of the pipeline means any unhandled
`ArgumentException` from a controller — or theoretically from auth/downstream middleware —
gets caught in one place and converted to a consistent `400 { message }` response, instead
of scattering try/catch blocks per-endpoint. This replaced 4 redundant try/catch blocks
across `SalesController`/`ExpensesController` (POST/PUT).

**Verified:** Invalid PUT (future-dated sale) still returns 400 with the guard clause's
exact message after the refactor — confirms the middleware didn't change validation
behavior, only where it's caught.

### EnsureCreated() over real migrations in test factory
**Decision:** `CustomWebApplicationFactory` builds the in-memory SQLite schema via
`EnsureCreated()` rather than running the actual EF Core migrations.

**Why:** The test suite's goal is verifying CRUD/API behavior, not verifying that the
migration files themselves are correct. `EnsureCreated()` builds the schema directly from
the current model, which is faster and avoids coupling test setup to migration history.
Trade-off, stated explicitly: this means migrations themselves are *not* covered by this
test suite — if a migration file itself is broken, these tests won't catch it. That's an
accepted gap given the test suite's scope.

### Test project placement
`IncomeTracker.Tests` is scaffolded as a sibling of `IncomeTracker` (the API project),
never nested inside it. Both are registered in `IncomeTracker.slnx`. (See postmortem
below for why this matters in practice, not just in theory.)

---

## Postmortems

### Day 97 — Test project folder-nesting bug (CS0436 duplicate type conflict)

**What happened:** `IncomeTracker.Tests` was originally scaffolded *nested inside* the
`IncomeTracker/` project folder instead of as a sibling. Since ASP.NET Core's default
project file globbing is recursive, the main API project silently picked up and compiled
the test project's `.cs` files too — including `CustomWebApplicationFactory.cs` — resulting
in `CS0436` (duplicate type definition) errors at build time.

**Root cause:** No `<Compile Remove>` exclusion existed for the nested Tests folder, and
implicit recursive globbing in the `.csproj` doesn't stop at project boundaries unless
explicitly told to.

**Fix:** Moved `IncomeTracker.Tests` out to sit as a sibling of `IncomeTracker` (both under
`practice/`), deleted the old nested copy, corrected the `<ProjectReference>` path in
`IncomeTracker.Tests.csproj`, and corrected the relative Tests path in `IncomeTracker.slnx`
(which itself stays inside `IncomeTracker/`, so the reference becomes
`../IncomeTracker.Tests/...`). Verified via clean `dotnet build` — no more conflict.

**Takeaway:** Test projects must be scaffolded as siblings, not children, of the project
under test — otherwise recursive globbing silently double-compiles shared files.

---

## Devlog

**Day 95** — Scaffolded `IncomeTracker`: `dotnet new` project, domain classes (`Sale`,
`Expense`) with constructor guard clauses, `IncomeTrackerDbContext`, first EF Core
migration, Scalar wired in. Built GET/POST on `SalesController`. Deferred PUT/DELETE — hit
an open design question: `Sale` has no public setters, so an update path needed an
explicit `Update(...)` method with guard clause re-execution before PUT could be written.

**Day 96–97** — Resolved the `Sale` update design question (see Design Decisions above).
Finished full CRUD on `SalesController` and `ExpensesController`, added computed
`GET /api/Income`. Added `ExceptionHandlingMiddleware`; removed 4 redundant try/catch
blocks from both controllers. Scaffolded `IncomeTracker.Tests` — hit the folder-nesting
bug (see Postmortems above), fixed by moving it to a sibling folder. Created
`IncomeTracker.slnx`, registered both projects. Started `SalesApiTests.cs` — first test
drafted but not fixed (missing `await` on `ReadFromJsonAsync`, meaningless assertion).

**Day 98** — Fixed `SalesApiTests`: corrected the missing `await`, fixed a
route-interpolation bug (`GetAsync("api/Sales/{testSale.Id}")` missing the `$` prefix),
replaced a shared mutable `_createdSaleId` field with a `List<int> _createdSaleIds` to
support safe multi-sale cleanup, and moved cleanup into `[TearDown]` with per-iteration
try/catch so one failed delete doesn't block cleanup of the rest. Wrote full
`SalesApiTests` coverage: Get (valid/NotFound), Update (valid/invalid, including verifying
the record is unchanged after a rejected update), Delete (including a follow-up GET to
confirm the resource is actually gone). Mirrored the full suite for `ExpensesApiTests`,
correctly reflecting the Sale/Expense date-validation asymmetry in the invalid-update
test. Wrote `README.md` and merged this file's design decisions with the existing
postmortems.