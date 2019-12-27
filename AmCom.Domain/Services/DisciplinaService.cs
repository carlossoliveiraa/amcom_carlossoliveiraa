using AmCom.Domain.Entities;
using AmCom.Domain.Interfaces.Repository;
using AmCom.Domain.Interfaces.Services;

namespace AmCom.Domain.Services
{
   
    public class DisciplinaService : ServiceBase<Disciplina>, IDisciplinaService
    {
        public DisciplinaService(IDisciplinaRepository repositoro) : base(repositoro)
        {

        }
    }
}
