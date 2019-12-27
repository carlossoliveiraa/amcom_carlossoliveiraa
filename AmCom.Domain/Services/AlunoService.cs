using AmCom.Domain.Entities;
using AmCom.Domain.Interfaces.Repository;
using AmCom.Domain.Interfaces.Services;

namespace AmCom.Domain.Services
{
    public class AlunoService : ServiceBase<Aluno>, IAlunoService
    {
        public AlunoService(IAlunoRepository repositoro) : base(repositoro)
        {

        }
    }
}
