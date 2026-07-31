using System.Net;
using System.Net.Http.Json;

namespace IncomeTracker.Tests;

public class ExpensesApiTests
{
    private CustomWebApplicationFactory _factory = null!;
    private HttpClient _client = null!;
    private List<int> _createdExpenseIds = new();
    private const int _TestInvalidId = -1;
    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _factory = new CustomWebApplicationFactory();
        _client = _factory.CreateClient();
    }
    [OneTimeTearDown]
    public void OneTimeTearDown()
    {
        _client.Dispose();
        _factory.Dispose();
    }
    [Test]
    public async Task GetExpenses_ReturnsSuccessOrNonEmptyList()
    {
        var (_,_) = await CreateTestExpense();

        var response = await _client.GetAsync($"api/Expenses");
        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK), $"Expected 200 Ok() status, but received {response.StatusCode}");
        
        var expenses = await response.Content.ReadFromJsonAsync<List<ExpenseResponse>>();
        Assert.That(expenses, Is.Not.Null);
        Assert.That(expenses.Count, Is.GreaterThan(0));
    }
    [Test]
    public async Task GetExpense_ValidId_ReturnsOk()
    {
        var(responseCreateTestExpense, testExpense) = await CreateTestExpense();
        Assert.That(responseCreateTestExpense.StatusCode, Is.EqualTo(HttpStatusCode.Created), $"Expected 201 Created() status, but received {responseCreateTestExpense.StatusCode}");
        Assert.That(testExpense, Is.Not.Null);

        var response = await _client.GetAsync($"api/Expenses/{testExpense.Id}");
        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK),$"Expected 200 Ok() status, but received {response.StatusCode}");

        var expense = await response.Content.ReadFromJsonAsync<ExpenseResponse>();
        Assert.That(expense, Is.Not.Null);
        Assert.That(expense.Id, Is.EqualTo(testExpense.Id));
        Assert.That(expense.Amount, Is.EqualTo(testExpense.Amount));
        Assert.That(expense.Date, Is.EqualTo(testExpense.Date));
    }
    [Test]
    public async Task GetExpense_NonExistentId_ReturnsNotFound()
    {
        var response = await _client.GetAsync($"api/Expenses/{_TestInvalidId}");
        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.NotFound), $"Expected 404 Not Found() status, but received {response.StatusCode}");
    }
    [Test]
    public async Task UpdateExpense_ValidRequest_ReturnsOk()
    {
        var(_, testExpense) = await CreateTestExpense();
        Assert.That(testExpense, Is.Not.Null);

        var payload = new {Amount = 999.99m, Date = new DateTime(2027, 07, 30)};
        var response = await _client.PutAsJsonAsync($"api/Expenses/{testExpense.Id}", payload);
        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK), $"Expected 200 Ok() status, but received {response.StatusCode}");

        var expense = await response.Content.ReadFromJsonAsync<ExpenseResponse>();
        Assert.That(expense, Is.Not.Null);
        Assert.That(expense.Id, Is.EqualTo(testExpense.Id));
        Assert.That(expense.Amount, Is.EqualTo(payload.Amount));
        Assert.That(expense.Date, Is.EqualTo(payload.Date));
    }
    [Test]
    public async Task UpdateExpense_InvalidRequest_ReturnsBadRequest()
    {
        var(_, testExpense) = await CreateTestExpense();
        Assert.That(testExpense, Is.Not.Null);

        var payload = new {Amount = -10, Date = new DateTime(2027, 07, 30)};
        var response = await _client.PutAsJsonAsync($"api/Expenses/{testExpense.Id}", payload);
        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.BadRequest), $"Expected 400 Bad Request(), but received {response.StatusCode}");

        var responseGetExpense = await _client.GetAsync($"api/Expenses/{testExpense.Id}");
        Assert.That(responseGetExpense.StatusCode, Is.EqualTo(HttpStatusCode.OK), $"Expected 200 Ok() status, but received {responseGetExpense.StatusCode}");

        var expense = await responseGetExpense.Content.ReadFromJsonAsync<ExpenseResponse>();
        Assert.That(expense, Is.Not.Null);
        Assert.That(expense.Id, Is.EqualTo(testExpense.Id));
        Assert.That(expense.Amount, Is.EqualTo(testExpense.Amount));
        Assert.That(expense.Date, Is.EqualTo(testExpense.Date));
    }
    [Test]
    public async Task DeleteExpense_ValidId_ReturnsNoContent()
    {
        var(_, testExpense) = await CreateTestExpense();
        Assert.That(testExpense, Is.Not.Null);

        var response = await _client.DeleteAsync($"api/Expenses/{testExpense.Id}");
        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.NoContent), $"Expected 204 No Content(), but received {response.StatusCode}");

        _createdExpenseIds.Remove(testExpense.Id);

        var responseGetExpense = await _client.GetAsync($"api/Expenses/{testExpense.Id}");
        Assert.That(responseGetExpense.StatusCode, Is.EqualTo(HttpStatusCode.NotFound), $"Expected 404 Not Found() status, but received {responseGetExpense.StatusCode}");
    }
    private async Task <(HttpResponseMessage Response, ExpenseResponse? Expense)> CreateTestExpense(decimal amount = 99.99m, DateTime? date = null)
    {
        var payload = new {Amount = amount, Date = date ?? DateTime.Now};

        var response = await _client.PostAsJsonAsync($"api/Expenses", payload);
        if(response.StatusCode != HttpStatusCode.Created)
        {
            throw new InvalidOperationException($"Expected 201 Created() status, but received {response.StatusCode}");
        }

        var expense = await response.Content.ReadFromJsonAsync<ExpenseResponse>();
        if(expense == null)
        {
            throw new InvalidOperationException("Expense is null in creating test expense (setup helper) but expected otherwise");
        }
        _createdExpenseIds.Add(expense.Id);

        return (response, expense);
    }
    [TearDown]
    public async Task DeleteTestExpense()
    {
        if(_createdExpenseIds.Count > 0)
        {
            int errorId = 0;
            foreach(int i in _createdExpenseIds)
            {
                try
                {
                    var response = await _client.DeleteAsync($"api/Expenses/{i}");
                    if(response.StatusCode != HttpStatusCode.NoContent)
                    {
                        errorId = i;
                        throw new InvalidOperationException($"Expected 204 No Content() status, but received {response.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    TestContext.Progress.WriteLine($"Warning: Failure in delete test expense with an id of {errorId}: {ex.Message}");
                }
            }
        }
        _createdExpenseIds.Clear();
    }
}