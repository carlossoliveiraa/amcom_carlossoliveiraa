using AmCom.Application.Dto;
using AmCom.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmCom.Application.Interfaces
{
    public interface IAppBase<TEntity, TEntityDTO> where TEntity : BaseEntity where TEntityDTO : DtoBase
    {
        int Create(TEntityDTO entity);
        void Delete(int id);
        void Delete(TEntityDTO entity);
        void Update(TEntityDTO entity);
        TEntityDTO GetById(int id);
        IEnumerable<TEntityDTO> GetAll();
    }
}
