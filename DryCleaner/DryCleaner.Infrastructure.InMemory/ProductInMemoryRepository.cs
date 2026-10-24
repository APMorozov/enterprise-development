using DryCleaner.Domain.Interfaces;
using DryCleaner.Domain.Entities;


namespace DryCleaner.Infrastructure.InMemory;

/// <summary>
/// Репозиторий для управления данными изделий в оперативной памяти.
/// </summary>
public class ProductInMemoryRepository : IRepository<Product, int>
{
    private readonly List<Product> _products = [];

    /// <summary>
    /// Добавляет изделие в коллекцию и возвращает добавленный объект.
    /// </summary>
    /// <param name="entity">Изделие для добавления.</param>
    /// <returns>Задача, представляющая асинхронную операцию, с добавленным изделием в качестве результата.</returns>
    public Task<Product> Create(Product entity)
    {
        _products.Add(entity);
        return Task.FromResult(entity);
    }


    /// <summary>
    /// Удаляет изделие по идентификатору.
    /// </summary>
    /// <param name="entityId">Идентификатор удаляемого изделия.</param>
    /// <returns>Значение true, если изделие успешно удалено; в противном случае — false.</returns>
    public Task<bool> Delete(int entityId)
    {
        var product = Read(entityId).Result;
        if (product == null)
            return Task.FromResult(false);

        var result = _products.Remove(product);
        return Task.FromResult(result);

    }

    /// <summary>
    /// Возвращает изделие с указанным идентификатором или null, если изделие не найдено.
    /// </summary>
    /// <param name="entityId">Идентификатор изделия.</param>
    /// <returns>Задача, представляющая асинхронную операцию, результатом которой является объект Product или null.</returns>
    public Task<Product?> Read(int entityId) => Task.FromResult(_products.FirstOrDefault(p => p.Id == entityId));

    /// <summary>
    /// Возвращает список всех изделий.
    /// </summary>
    /// <returns>Задача, представляющая асинхронную операцию, результатом которой является cписок изделий.</returns>
    public Task<IList<Product>> ReadAll() => Task.FromResult<IList<Product>>([.. _products]);

    /// <summary>
    /// Обновляет данные изделия или создает новое, если изделие не найдено.
    /// </summary>
    /// <param name="entity">Изделие с обновленными данными.</param>
    /// <returns>Задача, представляющая обновленного или созданного изделия.</returns>
    public Task<Product> Update(Product entity)
    {
        var product = Read(entity.Id).Result;

        if (product == null)
        {
            return Create(entity);
        }

        product.Name = entity.Name;
        product.Material = entity.Material;
        product.Category = entity.Category;
        return Task.FromResult(product);
    }
}
