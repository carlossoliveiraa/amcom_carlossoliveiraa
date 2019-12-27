using AmCom.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmCom.Domain.Interfaces.Services
{
    public interface IServiceBase<TEntity> where TEntity : BaseEntity
    {
        int Create(TEntity entidade);
        void Delete(int id);
        void Delete(TEntity entidade);
        void Update(TEntity entidade);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
    }
}
