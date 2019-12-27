using AmCom.Application.Dto;
using AmCom.Application.Interfaces;
using AmCom.Domain.Entities;
using AmCom.Domain.Interfaces.Services;
using AutoMapper;


namespace AmCom.Application.Services
{

    public class DisciplinaApp : ServiceAppBase<Disciplina, DisciplinaDto>, IDisciplinaApp
    {
        public DisciplinaApp(IMapper iMapper, IDisciplinaService servico) : base(iMapper, servico)
        {

        }
    }
}
