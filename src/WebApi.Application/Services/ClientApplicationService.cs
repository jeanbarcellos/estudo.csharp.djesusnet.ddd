using AutoMapper;
using System.Collections.Generic;
using WebApi.Application.DTO;
using WebApi.Application.Interfaces;
using WebApi.Domain.Core.Interfaces.Services;
using WebApi.Domain.Entities;

namespace WebApi.Application.Services
{
    public class ClientApplicationService : IClientApplicationService
    {
        private readonly IClientService _clientService;
        private readonly IMapper _mapper;

        public ClientApplicationService(IClientService clientService, IMapper mapper)
        {
            _clientService = clientService;
            _mapper = mapper;
        }

        public IEnumerable<ClientDTO> GetAll()
        {
            var clients = _clientService.GetAll();
            return _mapper.Map<IEnumerable<ClientDTO>>(clients);
        }

        public ClientDTO GetById(int id)
        {
            var client = _clientService.GetById(id);
            return _mapper.Map<ClientDTO>(client);
        }

        public void Add(ClientDTO clienteDTO)
        {
            var client = _mapper.Map<Client>(clienteDTO);
            _clientService.Add(client);
        }

        public void Update(ClientDTO clienteDTO)
        {
            var client = _mapper.Map<Client>(clienteDTO);
            _clientService.Update(client);
        }

        public void Remove(ClientDTO clienteDTO)
        {
            var client = _mapper.Map<Client>(clienteDTO);
            _clientService.Remove(client);
        }

    }
}
