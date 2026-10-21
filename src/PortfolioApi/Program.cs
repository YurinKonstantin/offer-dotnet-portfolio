using PortfolioApi.Shop;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<ProductCatalog>();

var app = builder.Build();

app.MapGet("/health", () => Results.Ok(new { status = "ok" }));

app.MapGet("/products", (ProductCatalog catalog) => Results.Ok(catalog.GetAll()));

app.MapGet("/products/{id:int}", (int id, ProductCatalog catalog) =>
    catalog.Find(id) is { } product ? Results.Ok(product) : Results.NotFound());

app.Run();

// Нужно тестам: WebApplicationFactory<Program> поднимает приложение в памяти.
public partial class Program { }
