using System;
using System.Collections.Generic;
using WebApi.Domain.Core.Interfaces.Repositories;
using WebApi.Domain.Core.Interfaces.Services;
using WebApi.Domain.Entities;

namespace WebApi.Domain.Services.Services
{
    abstract public class BaseService<TEntity> : IBaseService<TEntity>
        where TEntity : BaseEntity
    {
        private readonly IBaseRepository<TEntity> _repository;

        protected BaseService(IBaseRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public virtual TEntity GetById(int id)
        {
            return _repository.GetById(id);
        }

        public virtual void Add(TEntity entity)
        {
            _repository.Add(entity);
        }

        public virtual void Update(TEntity entity)
        {
            _repository.Update(entity);
        }

        public virtual void Remove(TEntity entity)
        {
            _repository.Remove(entity);
        }
    }
}
