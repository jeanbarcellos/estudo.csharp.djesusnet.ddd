using System.Collections.Generic;

namespace WebApi.Application.Interfaces
{
    interface IClientApplicationService
    {
        void Add(ClientDTO obj);

        ClientDTO GetById(int id);

        IEnumerable<ClientDTO> GetAll();

        void Update(ClientDTO obj);

        void Remove(ClientDTO obj);

        void Dispose();
    }
}
