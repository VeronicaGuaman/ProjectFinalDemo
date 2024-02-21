using ProjectFinalDemo.Domain.Entities;

namespace ProjectFinalDemo.Application.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductEntity>> GetAll();
    }
}
