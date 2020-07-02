using CQRS.Manually.Application.Queries;

namespace CQRS.Manually.Application.Dispatchers
{
    public interface IQueryDispatcher
    {
        TResult Query<TQuery, TResult>(TQuery query) where TQuery : IQuery<TResult>;
    }
}