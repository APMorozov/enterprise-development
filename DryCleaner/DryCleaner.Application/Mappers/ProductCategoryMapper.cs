using DryCleaner.Application.Contracts.Client;
using DryCleaner.Application.Contracts.Order;
using DryCleaner.Application.Contracts.Product;
using DryCleaner.Application.Contracts.ProductCategory;
using DryCleaner.Domain.Entities;

namespace DryCleaner.Application.Mappers;

/// <summary>
/// Преобразует сущности ProductCategory в объекты ProductCategoryDto или ProductCategoryDto в сущности ProductCategory.
/// </summary>
public static class ProductCategoryMapper
{
    /// <summary>
    /// Преобразует сущность ProductCategory в объект ProductCategoryDto.
    /// </summary>
    /// <param name="entity">Сущность ProductCategory для преобразования.</param>
    /// <returns>Экземпляр ProductCategoryDto, созданный на основе переданной сущности.</returns>
    public static ProductCategoryDto Map(ProductCategory entity)
    {
        return new(entity.Id, entity.Name, entity.RecommendedCleaningType, entity.CleaningPrice);
    }
}
