using System;

namespace CQRS.Manually.Application.Commands
{
    public class CreateOrder : ICommand
    {
        public Guid CustomerId { get; }

        public CreateOrder(Guid customerId)
        {
            CustomerId = customerId;
        }
    }
}