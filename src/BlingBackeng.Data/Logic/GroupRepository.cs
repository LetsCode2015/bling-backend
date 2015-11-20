using BlingBackend.Model;
using BlingBackeng.Data.Interface;

namespace BlingBackeng.Data.Logic
{
    public sealed class GroupRepository : RepositoryBase<Group>, IGroupRepository
    {
        public GroupRepository(BlingBackendDbContext dbContext) : base(dbContext)
        {
        }
    }
}