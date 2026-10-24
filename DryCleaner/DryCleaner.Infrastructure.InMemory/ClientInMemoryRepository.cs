using DryCleaner.Domain.Interfaces;
using DryCleaner.Domain.Entities;


namespace DryCleaner.Infrastructure.InMemory;

/// <summary>
/// Репозиторий для управления данными клиентов в оперативной памяти.
/// </summary>
public class ClientInMemoryRepository:IRepository<Client, int>
{
    private readonly List<Client> _clients = [];

    /// <summary>
    /// Добавляет клиента в коллекцию и возвращает добавленный объект.
    /// </summary>
    /// <param name="entity">Клиент для добавления.</param>
    /// <returns>Задача, представляющая асинхронную операцию, с добавленным клиентом в качестве результата.</returns>
    public Task<Client> Create(Client entity)
    {
        _clients.Add(entity);
        return Task.FromResult(entity);
    }


    /// <summary>
    /// Удаляет клиента по идентификатору.
    /// </summary>
    /// <param name="entityId">Идентификатор удаляемого клиента.</param>
    /// <returns>Значение true, если клиент успешно удален; в противном случае — false.</returns>
    public Task<bool> Delete(int entityId)
    {
        var client = Read(entityId).Result;
        if (client == null)
            return Task.FromResult(false);

        var result = _clients.Remove(client);
        return Task.FromResult(result);

    }

    /// <summary>
    /// Возвращает клиента с указанным идентификатором или null, если клиент не найден.
    /// </summary>
    /// <param name="entityId">Идентификатор клиента.</param>
    /// <returns>Задача, представляющая асинхронную операцию, результатом которой является объект Client или null.</returns>
    public Task<Client?> Read(int entityId) => Task.FromResult(_clients.FirstOrDefault(c => c.Id == entityId));

    /// <summary>
    /// Возвращает список всех клиентов.
    /// </summary>
    /// <returns>Задача, представляющая асинхронную операцию, результатом которой является cписок клиентов.</returns>
    public Task<IList<Client>> ReadAll() => Task.FromResult<IList<Client>>([.. _clients]);

    /// <summary>
    /// Обновляет данные клиента или создает нового, если клиент не найден.
    /// </summary>
    /// <param name="entity">Клиент с обновленными данными.</param>
    /// <returns>Задача, представляющая асинхронную операцию, результатом которой является обновленный или созданный клиент.</returns>
    public Task<Client> Update(Client entity)
    {
        var client = Read(entity.Id).Result;

        if (client == null)
        {
            return Create(entity);
        }

        client.Name = entity.Name;
        client.Phone = entity.Phone;
        return Task.FromResult(client);
    }
}
