namespace CQRS.Manually.Application.Queries
{
    public interface IQuery
    {
    }

    public interface IQuery<T> : IQuery
    {
    }
}