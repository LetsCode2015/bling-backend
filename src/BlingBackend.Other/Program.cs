using Autofac;
using BlingBackend.Autofac;
using BlingBackend.Model.Mocked;
using BlingBackeng.Data.Interface;

namespace BlingBackend.Other
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ContainerBuilder cb = new ContainerBuilder();
            cb.RegisterModule(new BlingBackendAutofacModule());
            var container = cb.Build();

            IUserRepository ur = container.Resolve<IUserRepository>();
            ur.Create(MockedUsers.Patryk);

            ICategoryRepository cr = container.Resolve<ICategoryRepository>();
            cr.Create(MockedCategories.HomeCategory);

            ITaskRepository tr = container.Resolve<ITaskRepository>();
            tr.Create(MockedTasks.BuyBeer);

            IBoardRepository br = container.Resolve<IBoardRepository>();
            br.Create(MockedBoards.HomeBoard);
        }
    }
}