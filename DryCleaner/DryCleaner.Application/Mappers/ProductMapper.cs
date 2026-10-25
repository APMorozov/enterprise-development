using DryCleaner.Application.Contracts.Product;
using DryCleaner.Domain.Entities;

namespace DryCleaner.Application.Mappers;

/// <summary>
/// Преобразует сущности Product в объекты ProductDto или ProductDto в сущности Product.
/// </summary>
internal class ProductMapper
{
    /// <summary>
    /// Преобразует сущность Product в объект ProductDto.
    /// </summary>
    /// <param name="entity">Сущность Product для преобразования.</param>
    /// <returns>Экземпляр ProductDto, созданный на основе переданной сущности.</returns>
    public static ProductDto Map(Product entity)
    {
        return new(entity.Id, entity.Name, entity.Material, ProductCategoryMapper.Map(entity.Category));
    }
}
