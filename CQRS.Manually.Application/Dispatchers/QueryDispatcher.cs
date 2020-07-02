using Autofac;
using CQRS.Manually.Application.Queries;
using CQRS.Manually.Application.Queries.Handlers;

namespace CQRS.Manually.Application.Dispatchers
{
    public class QueryDispatcher : IQueryDispatcher
    {
        private readonly IComponentContext context;

        public QueryDispatcher(IComponentContext context)
        {
            this.context = context;
        }

        public TResult Query<TQuery, TResult>(TQuery query) where TQuery : IQuery<TResult>
        {
            var handlerType = typeof(IQueryHandler<,>)
                .MakeGenericType(query.GetType(), typeof(TResult));

            dynamic handler = context.Resolve(handlerType);

            return handler.Handle((dynamic)query);
        }
    }
}
