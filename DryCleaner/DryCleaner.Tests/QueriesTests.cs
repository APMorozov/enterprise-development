using DryCleaner.Domain.Entities;
using DryCleaner.Domain.Enums;

namespace DryCleaner.Tests;

/// <summary>
/// Тесты запросов к данным сервиса
/// </summary>
/// <param name="fixture">Тестовый набор данных</param>
public class QueriesTests(QueriesTestsFixture fixture) : IClassFixture<QueriesTestsFixture>
{
    /// <summary>
    /// Проверяет информацию полученную о заказах, находящихся в обработке, упорядоченных по дате приема
    /// </summary>
    [Fact]
    public void InProgressOrdersInfoOrderedByAcceptedAt()
    {
        var orders = fixture.Orders.ToList();

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

    /// <summary>
    /// Проверяет информацию полученную о топ 5 самых активных клиантах за период
    /// </summary>
    [Fact]
    public void Top5MostActiveClientsForPeriod()
    {
        var dateFrom = new DateTime(2025, 1, 1);
        var dateTo = new DateTime(2026, 12, 31);

        var orders = fixture.Orders.ToList();

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


    /// <summary>
    /// Проверяет информацию полученную о клиентах с самым длительными заказами упорядоченных по имени
    /// </summary>
    [Fact]
    public void ClientsWithLongestProcessingOrdersOrderedByName()
    {
        var orders = fixture.Orders.ToList();

        var result = orders
            .GroupBy(order => order.Client)
            .Select(group => new
            {
                Client = group.Key,
                AverageProcessingDays =
                    group.Average(order => order.ProcessingDays)
            })
            .OrderBy(x => x.Client.Name)
            .ToList();

        Assert.NotEmpty(result);

        for (var i = 1; i < result.Count; i++)
        {
            Assert.True(
                string.Compare(
                    result[i - 1].Client.Name,
                    result[i].Client.Name,
                    StringComparison.Ordinal) <= 0);
        }
    }

    /// <summary>
    /// Проверяет информацию полученную о топ 5 самых популярных категориях за последний год
    /// </summary>
    [Fact]
    public void Top5MostAndLeastPopularCategoriesForLastYear()
    {
        var dateTo = new DateTime(2026, 9, 18);
        var dateFrom = dateTo.AddYears(-1);

        var orders = fixture.Orders.ToList();

        var categories = orders
            .Where(order =>
                order.AcceptedAt >= dateFrom &&
                order.AcceptedAt <= dateTo)
            .GroupBy(order => order.Product.Category)
            .Select(group => new
            {
                Category = group.Key,
                ProductsCount = group.Count()
            })
            .ToList();

        var mostPopular = categories
            .OrderByDescending(x => x.ProductsCount)
            .Take(5)
            .ToList();

        var leastPopular = categories
            .OrderBy(x => x.ProductsCount)
            .Take(5)
            .ToList();

        Assert.Equal(5, mostPopular.Count);
        Assert.Equal(5, leastPopular.Count);

        for (var i = 1; i < mostPopular.Count; i++)
        {
            Assert.True(
                mostPopular[i - 1].ProductsCount >=
                mostPopular[i].ProductsCount);
        }

        for (var i = 1; i < leastPopular.Count; i++)
        {
            Assert.True(
                leastPopular[i - 1].ProductsCount <=
                leastPopular[i].ProductsCount);
        }
    }


    /// <summary>
    /// Проверяет информацию полученную о клиенте потртившем самуб большую сумму за весь период работы сервиса
    /// </summary>
    [Fact]
    public void ClientWhoSpentTheMostMoney()
    {
        var orders = fixture.Orders.ToList();

        var result = orders
            .GroupBy(order => order.Client)
            .Select(group => new
            {
                Client = group.Key,
                TotalSpent = group.Sum(order =>
                    order.Product.Category.CleaningPrice)
            })
            .OrderByDescending(x => x.TotalSpent)
            .First();

        Assert.NotNull(result.Client);
        Assert.True(result.TotalSpent > 0);
    }
}
