using Autofac;
using CQRS.Manually.Application.Dispatchers;

namespace CQRS.Manually.Application.IoC
{
    public static class ApplicationModule
    {
        public static void AddDispatchers(this ContainerBuilder builder)
        {
            builder.RegisterType<CommandDispatcher>().As<ICommandDispatcher>();
            builder.RegisterType<Dispatcher>().As<IDispatcher>();
            builder.RegisterType<QueryDispatcher>().As<IQueryDispatcher>();
        }
    }
}