# Portfolio API

Проект для серии «Строим проект» из канала «Оффер .NET».

## Шаг 1. Каркас и health-проверка

- `src/PortfolioApi` — ASP.NET Core Web API (.NET 8), один эндпоинт `GET /health`.
- `tests/PortfolioApi.Tests` — интеграционный тест эндпоинта через `WebApplicationFactory`.

Запуск:

```
dotnet run --project src/PortfolioApi
dotnet test
```
