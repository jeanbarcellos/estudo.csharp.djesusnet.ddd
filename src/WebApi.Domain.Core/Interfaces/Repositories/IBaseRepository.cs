using System.Collections.Generic;
using WebApi.Domain.Entities;

namespace WebApi.Domain.Core.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity> 
        where TEntity : BaseEntity
    {
        IEnumerable<TEntity> GetAll();

        TEntity GetById(int id);

        void Add(TEntity entity);

        void Update(TEntity entity);

        void Remove(TEntity entity);
    }
}
