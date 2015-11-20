using Autofac;
using BlingBackeng.Data;
using BlingBackeng.Data.Interface;
using BlingBackeng.Data.Logic;

namespace BlingBackend.Autofac
{
    public class BlingBackendAutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            RegisterRepositories(builder);
            RegisterLogic(builder);
        }

        private void RegisterLogic(ContainerBuilder builder)
        {
        }

        private static void RegisterRepositories(ContainerBuilder builder)
        {
            builder.RegisterType<BlingBackendDbContext>()
                .AsSelf();

            builder.RegisterType<BoardRepositoryMocked>()
                .As<IBoardRepository>()
                .InstancePerDependency();

            builder.RegisterType<TaskRepositoryMocked>()
               .As<ITaskRepository>()
               .InstancePerDependency();
        }
    }
}