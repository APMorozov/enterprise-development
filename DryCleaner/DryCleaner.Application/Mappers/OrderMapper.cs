using DryCleaner.Application.Contracts.Order;
using DryCleaner.Domain.Entities;

namespace DryCleaner.Application.Mappers;

/// <summary>
/// Преобразует сущности Order в объекты ProductDto или ProductDto в сущности Product.
/// </summary>
internal class OrderMapper
{

    /// <summary>
    /// Преобразует объект заказа в объект OrderDto.
    /// </summary>
    /// <param name="entity">Сущность Order для преобразования.</param>
    /// <returns>Экземпляр OrderDto, созданный на основе переданной сущности.</returns>
    public static OrderDto Map(Order entity)
    {
        return new(entity.Id, ClientMapper.Map(entity.Client), ProductMapper.Map(entity.Product), entity.AcceptedAt, entity.ProcessingDays, entity.Status);
    }
}
