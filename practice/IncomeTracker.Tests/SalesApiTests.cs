using System.Net;
using System.Net.Http.Json;

namespace IncomeTracker.Tests;

public class SalesApiTests
{
    private CustomWebApplicationFactory _factory = null!;
    private HttpClient _client = null!;
    private int? _createdSaleId = null;
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
        _createdSaleId = sale.Id;

         return (response, sale);
    }
}