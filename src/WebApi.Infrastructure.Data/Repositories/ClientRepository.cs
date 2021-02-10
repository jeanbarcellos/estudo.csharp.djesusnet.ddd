using Microsoft.EntityFrameworkCore;
using WebApi.Domain.Core.Interfaces.Repositories;
using WebApi.Domain.Entities;
using WebApi.Infrastructure.Data.Repositories;

namespace WebApi.Infrastructure.Data
{
    public class ClientRepository : BaseRepository<Client>, IClientRepository
    {
        public ClientRepository(DbContext context) : base(context)
        {

        }
    }
}