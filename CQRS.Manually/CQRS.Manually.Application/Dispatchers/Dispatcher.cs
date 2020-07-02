using CQRS.Manually.Application.Commands;
using CQRS.Manually.Application.Queries;
using System;

namespace CQRS.Manually.Application.Dispatchers
{
    public class Dispatcher : IDispatcher
    {
        public TResult Query<TQuery, TResult>(TQuery query) where TQuery : IQuery<TResult> => throw new NotImplementedException();
        public void Send<TCommand>(TCommand command) where TCommand : ICommand => throw new NotImplementedException();
    }
}