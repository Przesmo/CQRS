using CQRS.Manually.Application.Commands;
using CQRS.Manually.Application.Queries;

namespace CQRS.Manually.Application.Dispatchers
{
    public interface IDispatcher
    {
        void Send<TCommand>(TCommand command) where TCommand : ICommand;

        TResult Query<TQuery, TResult>(TQuery query) where TQuery : IQuery<TResult>;
    }
}