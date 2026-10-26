using DryCleaner.Application.Contracts.ServiceInterfaces;
using DryCleaner.Application.Contracts.Client;

namespace DryCleaner.Api.Controllers;

public class ClientController(IClientService service, ILogger<ClientController> logger):
    CrudControllerBase<ClientDto, ClientCreateUpdateDto, int>(service, logger)
{


}
