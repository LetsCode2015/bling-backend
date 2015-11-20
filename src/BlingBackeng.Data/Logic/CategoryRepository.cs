using BlingBackend.Model;
using BlingBackeng.Data.Interface;

namespace BlingBackeng.Data.Logic
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(BlingBackendDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}