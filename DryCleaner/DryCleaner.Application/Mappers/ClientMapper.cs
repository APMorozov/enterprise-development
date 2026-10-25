using DryCleaner.Application.Contracts.Client;
using DryCleaner.Domain.Entities;

namespace DryCleaner.Application.Mappers;

/// <summary>
/// Преобразует сущности Client в объекты ClientDto или ClientDto в сущности Client.
/// </summary>
internal class ClientMapper
{
    /// <summary>
    /// Преобразует сущность Client в объект ClientDto.
    /// </summary>
    /// <param name="entity">Сущность Client для преобразования.</param>
    /// <returns>Экземпляр ClientDto, созданный на основе переданной сущности.</returns>
    public static ClientDto Map(Client entity)
    {
        return new(entity.Id, entity.Name, entity.Phone);
    }
}
