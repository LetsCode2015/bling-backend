using BlingBackend.Model;
using BlingBackeng.Data.Interface;

namespace BlingBackeng.Data.Logic
{
    public class TaskRepository : RepositoryBase<Task>, ITaskRepository
    {
        public TaskRepository(BlingBackendDbContext dbContext) : base(dbContext)
        {
        }
    }
}