using AmCom.Application.Dto;
using AmCom.Application.Interfaces;
using AmCom.Domain.Entities;

namespace AmCom.Service.Api.Controllers
{

    public class AlunoController : BaseController<Aluno, AlunoDto>
    {
        public AlunoController(IAlunoApp app) : base(app)
        {

        }
    }
}