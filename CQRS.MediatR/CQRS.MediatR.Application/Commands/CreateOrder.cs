using MediatR;
using System;

namespace CQRS.MediatR.Application.Commands
{
    public class CreateOrder : IRequest
    {
        public Guid CustomerId { get; set; }
    }
}