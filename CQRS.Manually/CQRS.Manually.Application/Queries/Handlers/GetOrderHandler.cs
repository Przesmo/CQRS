using CQRS.Manually.Application.DTOs;
using System;

namespace CQRS.Manually.Application.Queries.Handlers
{
    public class GetOrderHandler : IQueryHandler<GetOrder, OrderDto>
    {
        public OrderDto Handle(GetOrder query) => new OrderDto { CustomerId = Guid.NewGuid() };
    }
}