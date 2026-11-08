# LibraryApi
**Phase:** Practice, not part of the 68-app console curriculum

Small ASP.NET Core Web API built to rehearse the endpoint-building process step by step: entity with guards, DbContext and migration, DTOs, controller. Practice only: not deployed, no tests, no authentication.

## Stack
ASP.NET Core Web API, EF Core, SQLite, Swagger UI

## Endpoints
- `POST /api/books` creates a book. Returns 201 with a Location header, or 400 with `{ message }` when a guard fails.
- `GET /api/books/{id}` returns one book, or 404 with `{ message }`.

## Concepts Practiced
- Entity guards in the constructor: null, then empty or whitespace for `Title` and `Author`, and a negative `CopiesAvailable` rejected with `ArgumentOutOfRangeException`
- `private set` on all properties; titles and authors are trimmed, never lowercased
- `LibraryDbContext` with SQLite and an `AddBook` migration
- Request DTO as a class with every property `required`, response DTO as a record with a `FromBook` factory
- `try/catch (ArgumentException)` in the controller, mapped to 400
- `CreatedAtAction` pointing at the GET route, which is what builds the Location header

## Checked by hand
Six status checks passed: valid POST (201 with Location), empty title (400), negative copies (400), valid GET (200), unknown id (404), POST with a missing field (400 from the framework).

## Limits (on purpose)
- No automated tests
- No list, edit or delete endpoints
- No authentication
- Not deployed, no CI

## How to run
From the LibraryApi folder:
```
dotnet ef database update
dotnet run
```
Then open `/swagger` on the local URL shown in the console.

---
Practice project inside the [CSharpPractice](https://github.com/dreckieee/csharp) repo. The full portfolio API is [VapeShopInventoryAPI](https://github.com/dreckieee/VapeShopInventoryAPI).