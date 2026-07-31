# IncomeTracker

Practice ASP.NET Core Web API — track sales and expenses, compute net income.

## Status
CRUD complete for Sales and Expenses, computed net income endpoint, exception-handling middleware, full test suite (NUnit + WebApplicationFactory). Practice/scaffolding drill — not a portfolio project. See [DECISIONS.md](./DECISIONS.md) for design rationale and devlog.

## Stack
- ASP.NET Core Web API (.NET 10)
- Entity Framework Core + SQLite
- Scalar.AspNetCore (interactive API docs)
- NUnit + Microsoft.AspNetCore.Mvc.Testing (in-memory SQLite via `EnsureCreated()`)

## Endpoints
| Method | Route | Description |
|---|---|---|
| GET | `/api/Sales` | List all sales |
| GET | `/api/Sales/{id}` | Get a sale by ID |
| POST | `/api/Sales` | Create a sale |
| PUT | `/api/Sales/{id}` | Update a sale |
| DELETE | `/api/Sales/{id}` | Delete a sale |
| GET | `/api/Expenses` | List all expenses |
| GET | `/api/Expenses/{id}` | Get an expense by ID |
| POST | `/api/Expenses` | Create an expense |
| PUT | `/api/Expenses/{id}` | Update an expense |
| DELETE | `/api/Expenses/{id}` | Delete an expense |
| GET | `/api/Income` | Computed net income (total sales − total expenses) |

## How to run
```bash
# Apply migrations (creates incometracker.db)
dotnet ef database update

# Run the API
dotnet run
```
Once running in development mode, the interactive API reference is available at `/scalar`.

## Tests
```bash
dotnet test
```