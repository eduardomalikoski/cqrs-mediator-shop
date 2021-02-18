using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shop.Domain.Commands.Requests;
using Shop.Domain.Commands.Responses;

namespace Shop.Controllers
{
    [ApiController]
    [Route("v1/customers")]
    public class CustomerController : ControllerBase
    {
        // passando o FromBody pq o Request tá vindo do corpo da requisição
        // FromServices para fazer a injeção de dependência
        [HttpPost]
        [Route("")]
        public Task<CreateCustomerResponse> Create([FromServices] IMediator mediator, [FromBody] CreateCustomerRequest command)
        {
            return mediator.Send(command);
        }
    }
}