using BlingBackend.Logic.Interfaces;
using BlingBackend.Model;
using BlingBackeng.Data.Interface;

namespace BlingBackend.Logic
{
    public class CategoryLogic : LogicBase<Category>, ICategoryLogic
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryLogic(ICategoryRepository categoryRepository) 
            : base(categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
    }
}