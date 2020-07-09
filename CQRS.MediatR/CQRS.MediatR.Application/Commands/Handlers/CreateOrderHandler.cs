using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS.MediatR.Application.Commands.Handlers
{
    public class CreateOrderHandler : IRequestHandler<CreateOrder>
    {
        public Task<Unit> Handle(CreateOrder request, CancellationToken cancellationToken) => throw new System.NotImplementedException();
    }
}
