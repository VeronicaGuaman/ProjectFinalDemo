using ProjectFinalDemo.Application.Services.Interfaces;
using ProjectFinalDemo.Domain.Entities;
using ProjectFinalDemo.Domain.Repositories;

namespace ProjectFinalDemo.Application.Services
{
    public class ProductServices : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductServices(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<ProductEntity>> GetAll()
        {
            return await _productRepository.GetAllAsync();
        }
    }
}