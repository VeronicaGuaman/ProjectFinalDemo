using ProjectFinalDemo.Domain.Entities;
using ProjectFinalDemo.Domain.Repositories;
using ProjectFinalDomain.Infrastructure.Data.Data;

namespace ProjectFinalDomain.Infrastructure.Data.Repositories
{
    public class ProductRepository : GenericRepository<ProductEntity>, IProductRepository
    {
        public ProductRepository(DataContext context) : base(context)
        {
        }
    }
}