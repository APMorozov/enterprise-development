namespace DryCleaner.Application.Contracts.ServiceInterfaces;

/// <summary>
/// Определяет контракт для сервисов приложения, поддерживающих операции создания, получения, обновления и удаления
/// объектов.
/// </summary>
/// <typeparam name="TDto">Тип объекта передачи данных (DTO), используемый для вывода.</typeparam>
/// <typeparam name="TCreateUpdateDto">Тип объекта передачи данных (DTO), используемый для создания и обновления.</typeparam>
/// <typeparam name="Tkey">Тип ключа, идентификатора объекта.</typeparam>
public interface IAplicationService<TDto, TCreateUpdateDto, Tkey>
{
    public Task<TDto> Create(TCreateUpdateDto dto);

    public Task<TDto> Get(Tkey id);


    public Task<TDto> GetAll();

    public Task<TDto> Update(TCreateUpdateDto dto, Tkey id);

    public Task<bool> Delete(Tkey id);
}
