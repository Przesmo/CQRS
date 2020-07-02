using Autofac;
using CQRS.Manually.Application.Commands;
using CQRS.Manually.Application.Commands.Handlers;

namespace CQRS.Manually.Application.Dispatchers
{
    public class CommandDispatcher : ICommandDispatcher
    {
        private readonly IComponentContext context;

        public CommandDispatcher(IComponentContext context)
        {
            this.context = context;
        }

        public void Send<T>(T command) where T : ICommand =>
            context.Resolve<ICommandHandler<T>>().Handle(command);
    }
}