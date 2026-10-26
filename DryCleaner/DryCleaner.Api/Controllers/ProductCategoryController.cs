using DryCleaner.Application.Contracts.ServiceInterfaces;
using DryCleaner.Application.Contracts.ProductCategory;

namespace DryCleaner.Api.Controllers;

/// <summary>
/// Rонтроллер для управления категориями продуктов.
/// </summary>
/// <param name="service">Сервис для работы с категориями продуктов.</param>
/// <param name="logger">Логгер для записи событий контроллера.</param>
public class ProductCategoryController(IProductCategoryService service, ILogger<ProductCategoryController> logger) :
    CrudControllerBase<ProductCategoryDto, ProductCategoryCreateUpdateDto, int>(service, logger)
{


}
