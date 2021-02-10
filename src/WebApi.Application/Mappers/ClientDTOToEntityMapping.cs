using AutoMapper;
using WebApi.Application.DTO;
using WebApi.Domain.Entities;

namespace WebApi.Application.Mappers
{
    public class ClientDTOToEntityMapping : Profile
    {
        public ClientDTOToEntityMapping()
        {
            CreateMap<ClientDTO, Client>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(x => x.FirstName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(x => x.LastName))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(x => x.Email))
                .ForMember(dest => dest.CreatedAt, opt => opt.Ignore())
                .ForMember(dest => dest.Active, opt => opt.Ignore());
        }
    }
}
