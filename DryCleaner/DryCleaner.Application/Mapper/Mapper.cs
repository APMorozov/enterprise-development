using DryCleaner.Application.Contracts.Client;
using DryCleaner.Application.Contracts.Order;
using DryCleaner.Application.Contracts.Product;
using DryCleaner.Application.Contracts.ProductCategory;
using DryCleaner.Domain.Entities;

namespace DryCleaner.Application.Mapper;

/// <summary>
/// Предоставляет методы для преобразования сущностей домена в объекты передачи данных (DTO) и наоборот.
/// </summary>
public static class Mapper
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

    /// <summary>
    /// Преобразует сущность Product в объект ProductDto.
    /// </summary>
    /// <param name="entity">Сущность Product для преобразования.</param>
    /// <returns>Экземпляр ProductDto, созданный на основе переданной сущности.</returns>
    public static ProductDto Map(Product entity) 
    {
        return new(entity.Id, entity.Name, entity.Material, Map(entity.Category));
    }

    /// <summary>
    /// Преобразует объект Client в объект ClientDto.
    /// </summary>
    /// <param name="entity">Сущность Client для преобразования.</param>
    /// <returns>Экземпляр ClientDto, созданный на основе переданной сущности.</returns>
    public static ClientDto Map(Client entity)
    {
        return new(entity.Id, entity.Name, entity.Phone);
    }

    /// <summary>
    /// Преобразует объект заказа в объект OrderDto.
    /// </summary>
    /// <param name="entity">Сущность Order для преобразования.</param>
    /// <returns>Экземпляр OrderDto, созданный на основе переданной сущности.</returns>
    public static OrderDto Map(Order entity) 
    {
        return new(entity.Id, Map(entity.Client), Map(entity.Product), entity.AcceptedAt, entity.ProcessingDays, entity.Status);
    }

}
