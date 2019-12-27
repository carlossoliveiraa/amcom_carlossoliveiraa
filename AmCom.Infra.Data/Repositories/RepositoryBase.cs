using AmCom.Domain.Entities;
using AmCom.Domain.Interfaces.Repository;
using AmCom.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AmCom.Infra.Data.Repositories
{
    public class RepositoryBase<TEntidade> : IRepositoryBase<TEntidade>
     where TEntidade : BaseEntity
    {
        protected readonly Contexto contexto;

        public RepositoryBase(Contexto contexto)
            : base()
        {
            this.contexto = contexto;
        } 
        public int Create(TEntidade entidade)
        {
            contexto.InitTransacao();
            var id = contexto.Set<TEntidade>().Add(entidade).Entity.Id;
            contexto.SendChanges();
            return id;
        }

        public void Delete(int id)
        {
            var entidade = GetById(id);
            if (entidade != null)
            {
                contexto.InitTransacao();
                contexto.Set<TEntidade>().Remove(entidade);
                contexto.SendChanges();
            }
        }

        public void Delete(TEntidade entidade)
        {
            contexto.InitTransacao();
            contexto.Set<TEntidade>().Remove(entidade);
            contexto.SendChanges();
        }         

        public IEnumerable<TEntidade> GetAll()
        {
            return contexto.Set<TEntidade>().ToList();
        }

        public TEntidade GetById(int id)
        {
            return contexto.Set<TEntidade>().Find(id);
        }  
        public void Update(TEntidade entidade)
        {
            contexto.InitTransacao();
            contexto.Set<TEntidade>().Attach(entidade);
            contexto.Entry(entidade).State = EntityState.Modified;
            contexto.SendChanges();
        }
    }
}
