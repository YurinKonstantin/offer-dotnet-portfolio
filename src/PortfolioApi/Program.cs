var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/health", () => Results.Ok(new { status = "ok" }));

app.Run();

// Нужно тестам: WebApplicationFactory<Program> поднимает приложение в памяти.
public partial class Program { }
