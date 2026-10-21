using System.Net;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Mvc.Testing;
using PortfolioApi.Shop;
using Xunit;

public class ProductsTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly HttpClient _client;

    public ProductsTests(WebApplicationFactory<Program> factory) => _client = factory.CreateClient();

    [Fact]
    public async Task Get_products_returns_catalog()
    {
        var products = await _client.GetFromJsonAsync<List<Product>>("/products");

        Assert.NotNull(products);
        Assert.NotEmpty(products);
    }

    [Fact]
    public async Task Get_product_by_id_returns_it()
    {
        var product = await _client.GetFromJsonAsync<Product>("/products/1");

        Assert.NotNull(product);
        Assert.Equal(1, product.Id);
    }

    [Fact]
    public async Task Get_unknown_product_returns_404()
    {
        var response = await _client.GetAsync("/products/999");

        Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
    }
}
