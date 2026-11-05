namespace DryCleaner.Application.Contracts.Analitic;

/// <summary>
/// DTO для запроса самых и наименее популярных категорий изделий
/// </summary>
/// <param name="MostPopular">Топ 5 самых популярных категорий</param>
/// <param name="LeastPopular">Топ 5 наименее популярных категорий</param>
public record CategoriesPopularityDto(IList<CategoryOrdersCountDto> MostPopular, IList<CategoryOrdersCountDto> LeastPopular);