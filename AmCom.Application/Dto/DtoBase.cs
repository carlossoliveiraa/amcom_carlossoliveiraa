using System;
using System.Collections.Generic;
using System.Text;

namespace AmCom.Application.Dto
{
    public class DtoBase
    {
        public virtual int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public bool Ativo { get; set; }

    }
}
