namespace PortfolioApi.Shop;

// Каталог в памяти: на этом шаге база данных не нужна, она появится позже.
public sealed class ProductCatalog
{
    private readonly List<Product> _products =
    [
        new(1, "Клавиатура", 4990m, 12),
        new(2, "Мышь", 1990m, 30),
        new(3, "Монитор 27\"", 19990m, 5),
    ];

    public IReadOnlyList<Product> GetAll() => _products;

    public Product? Find(int id) => _products.FirstOrDefault(p => p.Id == id);
}
