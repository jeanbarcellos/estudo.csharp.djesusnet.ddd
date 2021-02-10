using System.Collections.Generic;

namespace WebApi.Application.Interfaces
{
    public interface IProductApplicationService
    {
        void Add(ProductDTO obj);

        ProductDTO GetById(int id);

        IEnumerable<ProductDTO> GetAll();

        void Update(ProductDTO obj);

        void Remove(ProductDTO obj);

        void Dispose();
    }
}
