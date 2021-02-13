using AutoMapper;
using WebApi.Application.DTO;
using WebApi.Domain.Entities;

namespace WebApi.Application.Mappings
{
    public class ProductEntityToDTOMapping : Profile
    {
        public ProductEntityToDTOMapping()
        {
            CreateMap<Product, ProductDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(x => x.Name))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(x => x.Value));
        }
    }
}
