using CQRS.MediatR.Application.DTOs;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS.MediatR.Application.Queries.Handlers
{
    public class GetOrderHandler : IRequestHandler<GetOrder, OrderDto>
    {
        public Task<OrderDto> Handle(GetOrder request, CancellationToken cancellationToken) => throw new System.NotImplementedException();
    }
}