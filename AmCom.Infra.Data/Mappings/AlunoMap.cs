using AmCom.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AmCom.Infra.Data.Mappings
{
    public class AlunoMap : MapBase<Aluno>
    {
        public override void Configure(EntityTypeBuilder<Aluno> builder)
        {
            base.Configure(builder);
            builder.ToTable("Alunos");
            builder.Property(c => c.Nome).HasColumnName("Nome");
            builder.Property(c => c.Email).HasColumnName("Email").HasMaxLength(100);
            builder.Property(c => c.Cpf).HasColumnName("Cpf").HasMaxLength(100);
            builder.Property(c => c.DtNascimento).HasColumnName("DtNascimento");
            builder.Property(c => c.DataCadastro).IsRequired().HasColumnName("DataCadastro");
            builder.Property(c => c.DataAlteracao).HasColumnName("DataAlteracao");
            builder.Property(c => c.Ativo).HasColumnName("Ativo");
        }
    }
}
