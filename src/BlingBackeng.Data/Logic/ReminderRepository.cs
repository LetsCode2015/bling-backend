using BlingBackend.Model;
using BlingBackeng.Data.Interface;

namespace BlingBackeng.Data.Logic
{
    public class ReminderRepository : RepositoryBase<Reminder>, IReminderRepository
    {
        public ReminderRepository(BlingBackendDbContext dbContext) : base(dbContext)
        {
        }
    }
}