using DryCleaner.Domain.Data;
using DryCleaner.Domain.Entities;
using DryCleaner.Domain.Enums;

namespace DryCleaner.Tests;

internal class QueriesTestsFixture
{
    public IReadOnlyList<ProductCategory> Categories { get; } = DataSeed.Categories;
    public IReadOnlyList<Client> Clients { get; } = DataSeed.Clients;
    public IReadOnlyList<Product> Products { get; } = DataSeed.Products;



}
