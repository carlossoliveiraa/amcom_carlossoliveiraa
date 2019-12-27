using AmCom.Domain.Entities;
using AmCom.Domain.Interfaces.Repository;
using AmCom.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmCom.Infra.Data.Repositories
{
   
    public class AlunoRepository : RepositoryBase<Aluno>, IAlunoRepository
    {
        public AlunoRepository(Contexto contexto)
            : base(contexto)
        {
        }
    }
}
