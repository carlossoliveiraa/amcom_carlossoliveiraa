using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AmCom.Domain.Entities
{
    /// <summary>
    /// SOLID - Open-Closed Principle
    /// </summary>
    public class Aluno : BaseEntity
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        [Display(Name = "Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime? DtNascimento { get; set; }
    }
}
