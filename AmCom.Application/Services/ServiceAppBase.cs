using AmCom.Application.Dto;
using AmCom.Application.Interfaces;
using AmCom.Domain.Entities;
using AmCom.Domain.Interfaces.Services;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmCom.Application.Services
{
    public class ServiceAppBase<TEntidade, TEntidadeDTO> : IAppBase<TEntidade, TEntidadeDTO> where TEntidade : BaseEntity where TEntidadeDTO : DtoBase
    {
        protected readonly IServiceBase<TEntidade> servico;
        protected readonly IMapper iMapper;

        public ServiceAppBase(IMapper iMapper, IServiceBase<TEntidade> servico) : base()
        {
            this.iMapper = iMapper;
            this.servico = servico;
        }

        public int Create(TEntidadeDTO entidade)
        {
            return servico.Create(iMapper.Map<TEntidade>(entidade));
        }

        public void Delete(int id)
        {
            servico.Delete(id);
        }

        public void Delete(TEntidadeDTO entidade)
        {
            servico.Delete(iMapper.Map<TEntidade>(entidade));
        }

        public IEnumerable<TEntidadeDTO> GetAll()
        {
            return iMapper.Map<IEnumerable<TEntidadeDTO>>(servico.GetAll());
        } 

        public TEntidadeDTO GetById(int id)
        {
            return iMapper.Map<TEntidadeDTO>(servico.GetById(id));
        }

        public void Update(TEntidadeDTO entidade)
        {
            servico.Update(iMapper.Map<TEntidade>(entidade));
        }
    }
}
