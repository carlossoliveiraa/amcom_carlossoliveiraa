using AmCom.Application.Dto;
using AmCom.Application.Interfaces;
using AmCom.Domain.Entities;

namespace AmCom.Service.Api.Controllers
{

    public class DisciplinaController : BaseController<Disciplina, DisciplinaDto>
    {
        public DisciplinaController(IDisciplinaApp app) : base(app)
        {

        }
    }
}