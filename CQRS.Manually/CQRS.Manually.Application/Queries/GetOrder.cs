using CQRS.Manually.Application.DTOs;
using System;

namespace CQRS.Manually.Application.Queries
{
    public class GetOrder : IQuery<OrderDto>
    {
        public Guid CustomerId { get; set; }
    }
}