using ProjectFinalDemo.Domain.Entities;
using ProjectFinalDemo.Domain.Repositories;
using ProjectFinalDomain.Infrastructure.Data.Data;

namespace ProjectFinalDomain.Infrastructure.Data.Repositories
{
    public class CategoryRepository : GenericRepository<CategoryEntity>, ICategoryRepository
    {
        public CategoryRepository(DataContext context) : base(context)
        {

        }
    }
}
