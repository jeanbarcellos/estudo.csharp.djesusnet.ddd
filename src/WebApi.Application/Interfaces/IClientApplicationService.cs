using System.Collections.Generic;
using WebApi.Application.DTO;

namespace WebApi.Application.Interfaces
{
    interface IClientApplicationService
    {
        void Add(ClientDTO clientDTO);

        void Update(ClientDTO clientDTO);

        void Remove(ClientDTO clientDTO);

        ClientDTO GetById(int id);

        IEnumerable<ClientDTO> GetAll();
    }
}
