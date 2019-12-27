using AmCom.Domain.Entities;
using AmCom.Domain.Interfaces.Repository;
using AmCom.Infra.Data.Context;


namespace AmCom.Infra.Data.Repositories
{

    public class DisciplinaRepository : RepositoryBase<Disciplina>, IDisciplinaRepository
    {
        public DisciplinaRepository(Contexto contexto)
            : base(contexto)
        {
        }
    }
}
