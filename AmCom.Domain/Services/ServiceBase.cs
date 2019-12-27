using AmCom.Domain.Entities;
using AmCom.Domain.Interfaces.Repository;
using AmCom.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace AmCom.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : BaseEntity
    {
        protected readonly IRepositoryBase<TEntity> repository;

        public ServiceBase(IRepositoryBase<TEntity> repositorio)
        {
            this.repository = repositorio;
        }

        public int Create(TEntity entidade)
        {
            return repository.Create(entidade);
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }

        public void Delete(TEntity entidade)
        {
            repository.Delete(entidade);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return repository.GetAll();
        }

        public TEntity GetById(int id)
        {
            return repository.GetById(id);
        }

        public void Update(TEntity entidade)
        {
            repository.Update(entidade);
        }
    }
}
