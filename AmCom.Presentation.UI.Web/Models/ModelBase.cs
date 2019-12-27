using System;

namespace AmCom.Presentation.UI.Web.Models
{
    public class ModelBase
    {
        public virtual long Id { get; set; }
        public long? EmpresaId { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public bool Ativo { get; set; }
    }
}