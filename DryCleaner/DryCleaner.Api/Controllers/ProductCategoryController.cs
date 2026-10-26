using DryCleaner.Application.Contracts.ServiceInterfaces;
using DryCleaner.Application.Contracts.ProductCategory;

namespace DryCleaner.Api.Controllers;

public abstract class ProductCategoryController(IProductCategoryService service, ILogger<ProductCategoryController> logger) :
    CrudControllerBase<ProductCategoryDto, ProductCategoryCreateUpdateDto, int>(service, logger)
{


}
