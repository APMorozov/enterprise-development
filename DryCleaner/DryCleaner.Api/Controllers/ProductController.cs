using DryCleaner.Application.Contracts.ServiceInterfaces;
using DryCleaner.Application.Contracts.Product;

namespace DryCleaner.Api.Controllers;

public abstract class ProductController(IProductService service, ILogger<ProductController> logger) :
    CrudControllerBase<ProductDto, ProductCreateUpdateDto, int>(service, logger)
{


}
