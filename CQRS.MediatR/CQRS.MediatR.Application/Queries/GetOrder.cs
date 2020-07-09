using CQRS.MediatR.Application.DTOs;
using MediatR;
using System;

namespace CQRS.MediatR.Application.Queries
{
    public class GetOrder : IRequest<OrderDto>
    {
        public Guid CustomerId { get; set; }
    }
}