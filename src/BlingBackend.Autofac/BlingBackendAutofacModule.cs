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

            builder.RegisterType<BoardRepository>()
                .As<IBoardRepository>()
                .InstancePerDependency();

            builder.RegisterType<TaskRepository>()
               .As<ITaskRepository>()
               .InstancePerDependency();

            builder.RegisterType<UserRepository>()
               .As<IUserRepository>()
               .InstancePerDependency();

            builder.RegisterType<IGroupRepository>()
               .As<IUserRepository>()
               .InstancePerDependency();
        }
    }
}