using BlingBackend.Model;
using BlingBackeng.Data.Interface;
using System.Linq;

namespace BlingBackeng.Data.Logic
{
    public sealed class TaskRepository : ITaskRepository
    {
        public IQueryable<Task> GetTasks()
        {
            throw new System.NotImplementedException();
        }
    }
}