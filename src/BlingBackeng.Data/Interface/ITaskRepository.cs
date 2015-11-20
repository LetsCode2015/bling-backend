using BlingBackend.Model;
using System.Linq;

namespace BlingBackeng.Data.Interface
{
    public interface ITaskRepository
    {
        IQueryable<Task> GetTasks();
    }
}