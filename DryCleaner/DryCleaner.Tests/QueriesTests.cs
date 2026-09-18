using DryCleaner.Domain.Data;
using DryCleaner.Domain.Entities;
using DryCleaner.Domain.Enums;

namespace DryCleaner.Tests;

public class QueriesTests(QueriesTestsFixture fixture) : IClassFixture<QueriesTestsFixture>
{
    /// <summary>
    /// Списик категорий изделия
    /// </summary>
    private readonly List<ProductCategory> _categories = fixture.Categories.ToList();

    /// <summary>
    /// Список клиентов
    /// </summary>
    private readonly List<Client> _clients = fixture.Clients.ToList();

    /// <summary>
    /// Список изделий
    /// </summary>
    private readonly List<Product> _products = fixture.Products.ToList();

    /// <summary>
    /// Список заказов
    /// </summary>
    private readonly List<Order> _orders = fixture.Orders.ToList();

    [Fact]
    public void InProgressOrdersInfoOrderedByAcceptedAt()
    {
        var orders = _orders;

        var result = orders
            .Where(order => order.Status == OrderStatus.InProgress)
            .OrderBy(order => order.AcceptedAt)
            .ToList();

        Assert.NotEmpty(result);

        Assert.All(
            result,
            order => Assert.Equal(
                OrderStatus.InProgress,
                order.Status));

        for (var i = 1; i < result.Count; ++i)
        {
            Assert.True(
                result[i - 1].AcceptedAt <= result[i].AcceptedAt);
        }
    }

    [Fact]
    public void Top5MostActiveClientsForPeriod()
    {
        var dateFrom = new DateTime(2025, 1, 1);
        var dateTo = new DateTime(2025, 12, 31);
        
        var orders = _orders;

        var result = orders
            .Where(order =>
            order.AcceptedAt >= dateFrom &&
            order.AcceptedAt <= dateTo)
            .GroupBy(order => order.Client)
            .Select(group => new
            {
                Client = group.Key,
                ProductsCount = group.Count()
            })
            .OrderByDescending(x => x.ProductsCount)
            .Take(5)
            .ToList();

        Assert.Equal(5, result.Count());

        Assert.All(
        result,
        item => Assert.NotNull(item.Client));

        for (var i = 1; i < result.Count; i++)
        {
            Assert.True(
                result[i - 1].ProductsCount >=
                result[i].ProductsCount);
        }
    }
}
