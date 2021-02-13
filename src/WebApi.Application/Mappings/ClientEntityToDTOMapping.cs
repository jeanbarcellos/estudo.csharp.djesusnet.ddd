using AutoMapper;
using WebApi.Application.DTO;
using WebApi.Domain.Entities;

namespace WebApi.Application.Mappings
{
    public class ClientEntityToDTOMapping : Profile
    {
        public ClientEntityToDTOMapping()
        {
            CreateMap<Client, ClientDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(x => x.FirstName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(x => x.LastName))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(x => x.Email));
        }
    }
}
