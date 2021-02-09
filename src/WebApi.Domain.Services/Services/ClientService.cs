using WebApi.Domain.Core.Interfaces.Repositories;
using WebApi.Domain.Core.Interfaces.Services;
using WebApi.Domain.Entities;

namespace WebApi.Domain.Services.Services
{
    public class ClientService : BaseService<Client>, IClientService
    {
        public ClientService(IClientRepository repository) : base(repository)
        {

        }
    }
}
