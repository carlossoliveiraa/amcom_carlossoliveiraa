using System;
using System.Collections.Generic;
using System.Text;

namespace AmCom.Application.Dto
{
    public class AlunoDto : DtoBase
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime? DtNascimento { get; set; }
    }
}
