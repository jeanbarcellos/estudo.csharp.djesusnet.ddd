using AutoMapper;
using WebApi.Application.DTO;
using WebApi.Domain.Entities;

namespace WebApi.Application.Mappings
{
    public class ProductDTOToEntityMapping : Profile
    {
        public ProductDTOToEntityMapping()
        {
            CreateMap<ProductDTO, Product>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.Name, opt => opt.MapFrom(x => x.Name))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(x => x.Value))
                .ForMember(dest => dest.Visible, opt => opt.Ignore());
        }
    }
}
