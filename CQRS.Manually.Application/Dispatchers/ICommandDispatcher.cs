using CQRS.Manually.Application.Commands;

namespace CQRS.Manually.Application.Dispatchers
{
    public interface ICommandDispatcher
    {
        void Send<T>(T command) where T : ICommand;
    }
}