using WebApi.Domain.Core.Interfaces.Repositories;
using WebApi.Domain.Core.Interfaces.Services;
using WebApi.Domain.Entities;

namespace WebApi.Domain.Services.Services
{
    public class ProductService : BaseService<Product>, IProductService
    {
        public ProductService(IProductRepository repository) : base(repository)
        {

        }
    }
}
