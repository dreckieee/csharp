using System.Net;
using System.Net.Http.Json;

namespace IncomeTracker.Tests;

public class SalesApiTests
{
    private CustomWebApplicationFactory _factory = null!;
    private HttpClient _client = null!;
    private List<int> _createdSaleIds = new();
    private const int _TestInvalidId = -1;
    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _factory = new CustomWebApplicationFactory();
        _client = _factory.CreateClient();
    }
    [OneTimeTearDown]
    public void OneTimeTeardown()
    {
        _client.Dispose();
        _factory.Dispose();
    }

    [Test]
    public async Task GetSales_ReturnsSuccessAndNonEmptyList()
    {
        var (_, _) = await CreateTestSale();
        
        var response = await _client.GetAsync("api/Sales");
        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK), $"Expected 200 Ok() status, but received {response.StatusCode}");

        var sales = await response.Content.ReadFromJsonAsync<List<SaleResponse>>();
        Assert.That(sales, Is.Not.Null);
        Assert.That(sales.Count, Is.GreaterThan(0));
    }
    [Test]
    public async Task GetSale_ValidId_ReturnsOk()
    {
        var (responseCreateSale, testSale) = await CreateTestSale();
        Assert.That(responseCreateSale.StatusCode, Is.EqualTo(HttpStatusCode.Created), $"Expected 200 Ok() status, but received {responseCreateSale.StatusCode}");
        Assert.That(testSale, Is.Not.Null);

        var response = await _client.GetAsync($"api/Sales/{testSale.Id}");
        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK), $"Expected 200 Ok() status, but received {response.StatusCode}");

        var sale = await response.Content.ReadFromJsonAsync<SaleResponse>();
        Assert.That(sale, Is.Not.Null);
        Assert.That(sale.Id, Is.EqualTo(testSale.Id));
        Assert.That(sale.Amount, Is.EqualTo(testSale.Amount));
        Assert.That(sale.Date, Is.EqualTo(testSale.Date));
    }
    [Test]
    public async Task GetSale_NonExistentId_ReturnsNotFound()
    {
        var response = await _client.GetAsync($"api/Sales/{_TestInvalidId}");
        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.NotFound), $"Expected 404 Not Found() status, but received {response.StatusCode}");
    }
    [Test]
    public async Task UpdateSale_ValidRequest_ReturnsOk()
    {
        var(_, testSale) = await CreateTestSale();
        Assert.That(testSale, Is.Not.Null);

        var payload = new {Amount = 999.99m, Date = new DateTime (2026, 6, 30)};
        var response = await _client.PutAsJsonAsync($"api/Sales/{testSale.Id}", payload);
        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK), $"Expected 200 Ok() status, but received {response.StatusCode}");

        var sale = await response.Content.ReadFromJsonAsync<SaleResponse>();
        Assert.That(sale, Is.Not.Null);
        Assert.That(sale.Id, Is.EqualTo(testSale.Id));
        Assert.That(sale.Amount, Is.EqualTo(payload.Amount));
        Assert.That(sale.Date, Is.EqualTo(payload.Date));
    }
    [Test]
    public async Task UpdateSale_InvalidRequest_ReturnsBadRequest()
    {
        var (_, testSale) = await CreateTestSale();
        Assert.That(testSale, Is.Not.Null);

        var payload = new {Amount = 10, Date = new DateTime(2027, 07, 30)};
        var response = await _client.PutAsJsonAsync($"api/Sales/{testSale.Id}", payload);
        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.BadRequest), $"Expeceted 400 Bad Request() status, but received {response.StatusCode}");

        var responseGetSale = await _client.GetAsync($"api/Sales/{testSale.Id}");
        Assert.That(responseGetSale.StatusCode, Is.EqualTo(HttpStatusCode.OK), $"Expected 200 Ok() status, but received {responseGetSale.StatusCode}");

        var sale = await responseGetSale.Content.ReadFromJsonAsync<SaleResponse>();
        Assert.That(sale, Is.Not.Null);
        Assert.That(sale.Id, Is.EqualTo(testSale.Id));
        Assert.That(sale.Amount, Is.EqualTo(testSale.Amount));
        Assert.That(sale.Date, Is.EqualTo(testSale.Date));
    }
    [Test]
    public async Task DeleteSale_ValidId_ReturnsNoContent()
    {
        var (_, testSale) = await CreateTestSale();
        Assert.That(testSale, Is.Not.Null);

        var response = await _client.DeleteAsync($"api/Sales/{testSale.Id}");
        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.NoContent), $"Expected 204 No Content() status, but received {response.StatusCode}");

        _createdSaleIds.Remove(testSale.Id);

        var responseGetSale = await _client.GetAsync($"api/Sales/{testSale.Id}");
        Assert.That(responseGetSale.StatusCode, Is.EqualTo(HttpStatusCode.NotFound), $"Expected 404 Not Found() status, but received {responseGetSale.StatusCode}");
    }

    private async Task <(HttpResponseMessage Response, SaleResponse? Sale)> CreateTestSale(decimal amount = 99.99m, DateTime? date = null)
    {
        var payload = new
        {
            Amount = amount,
            Date = date ?? DateTime.Now
        };

        var response = await _client.PostAsJsonAsync("api/Sales", payload);
        if (response.StatusCode != HttpStatusCode.Created)
        {
            throw new InvalidOperationException($"Expected 201 Created() status in creating test sale (setup helper), but received {response.StatusCode}");
        }
       
        var sale = await response.Content.ReadFromJsonAsync<SaleResponse>();
        if (sale == null)
        {
            throw new InvalidOperationException($"Sale is null in creating test sale (setup helper) but expected otherwise");
        }
        _createdSaleIds.Add(sale.Id);

         return (response, sale);
    }

    [TearDown]
    public async Task DeleteTestSale()
    {
        if(_createdSaleIds.Count > 0)
        {
            int errorId = 0;
            foreach(int i in _createdSaleIds)
            {
                try
                {
                    var response = await _client.DeleteAsync($"api/Sales/{i}");
                    if(response.StatusCode != HttpStatusCode.NoContent)
                    {
                        errorId = i;
                        throw new Exception($"Expected 204 No Content() status, but received {response.StatusCode}");
                    }
                }
                catch(Exception ex)
                {
                    TestContext.Progress.WriteLine($"Warning: Failure in cancelling a sale with an Id of {errorId}: {ex.Message}");
                }
            }
            _createdSaleIds.Clear();
        }
    }
}