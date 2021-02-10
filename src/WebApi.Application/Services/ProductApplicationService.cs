using AutoMapper;
using System.Collections.Generic;
using WebApi.Application.DTO;
using WebApi.Application.Interfaces;
using WebApi.Domain.Core.Interfaces.Services;
using WebApi.Domain.Entities;

namespace WebApi.Application.Services
{
    public class ProductApplicationService : IProductApplicationService
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductApplicationService(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        public IEnumerable<ProductDTO> GetAll()
        {
            var products = _productService.GetAll();
            return _mapper.Map<IEnumerable<ProductDTO>>(products);
        }

        public ProductDTO GetById(int id)
        {
            var product = _productService.GetById(id);
            return _mapper.Map<ProductDTO>(product);
        }

        public void Add(ProductDTO producteDTO)
        {
            var product = _mapper.Map<Product>(producteDTO);
            _productService.Add(product);
        }

        public void Update(ProductDTO producteDTO)
        {
            var product = _mapper.Map<Product>(producteDTO);
            _productService.Update(product);
        }

        public void Remove(ProductDTO producteDTO)
        {
            var product = _mapper.Map<Product>(producteDTO);
            _productService.Remove(product);
        }

    }
}
