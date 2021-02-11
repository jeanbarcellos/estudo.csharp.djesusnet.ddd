using System.Collections.Generic;
using WebApi.Application.DTO;

namespace WebApi.Application.Interfaces
{
    public interface IClientApplicationService
    {
        IEnumerable<ClientDTO> GetAll();

        ClientDTO GetById(int id);

        void Add(ClientDTO clientDTO);

        void Update(ClientDTO clientDTO);

        void Remove(ClientDTO clientDTO);
    }
}
