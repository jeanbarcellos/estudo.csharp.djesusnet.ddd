using System.Collections.Generic;
using WebApi.Application.DTO;

namespace WebApi.Application.Interfaces
{
    public interface IProductApplicationService
    {
        IEnumerable<ProductDTO> GetAll();

        ProductDTO GetById(int id);

        void Add(ProductDTO productDTO);        

        void Update(ProductDTO productDTO);

        void Remove(ProductDTO productDTO);
    }
}
