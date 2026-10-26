using DryCleaner.Application.Contracts.ServiceInterfaces;
using DryCleaner.Application.Contracts.Order;

namespace DryCleaner.Api.Controllers;

public abstract class OrderController(IOrderService service, ILogger<OrderController> logger) :
    CrudControllerBase<OrderDto, OrderCreateUpdateDto, int>(service, logger)
{


}
