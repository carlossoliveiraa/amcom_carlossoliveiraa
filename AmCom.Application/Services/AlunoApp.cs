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
    
    public class AlunoApp : ServiceAppBase<Aluno, AlunoDto>, IAlunoApp
    {
        public AlunoApp(IMapper iMapper, IAlunoService servico) : base(iMapper, servico)
        {

        }
    }
}
