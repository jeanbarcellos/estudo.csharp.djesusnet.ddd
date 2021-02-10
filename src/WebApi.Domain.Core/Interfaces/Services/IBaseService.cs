using System.Collections.Generic;
using WebApi.Domain.Entities;

namespace WebApi.Domain.Core.Interfaces.Services
{
    public interface IBaseService<TEntity> where TEntity : BaseEntity
    {
        IEnumerable<TEntity> GetAll();

        TEntity GetById(int id);

        void Add(TEntity entity);

        void Update(TEntity entity);

        void Remove(TEntity entity);
    }
}
