using MediatR;
using Shop.Domain.Commands.Responses;

namespace Shop.Domain.Commands.Requests
{
    public class CreateCustomerRequest : IRequest<CreateCustomerResponse>
    {
        // Divisão da aplicação por leitura e escrita. Commands Query Responsability Segregation Segregação de Responsabilidade por Leitura e Escrita por comandos e queries
        public string Name { get; set; }
        public string Email { get; set; }
    }
}