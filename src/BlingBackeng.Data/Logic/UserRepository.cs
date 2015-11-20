using BlingBackend.Model;
using BlingBackeng.Data.Interface;

namespace BlingBackeng.Data.Logic
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(BlingBackendDbContext dbContext) 
            : base(dbContext)
        {
        }
    }
}