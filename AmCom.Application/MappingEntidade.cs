using AmCom.Application.Dto;
using AmCom.Domain.Entities;
using AutoMapper;
 

namespace AmCom.Application
{
   public class MappingEntidade: Profile
    {
        public MappingEntidade()
        {
            CreateMap<Aluno, AlunoDto>().ReverseMap();
            CreateMap<Disciplina, DisciplinaDto>().ReverseMap();
        }
    }
}
