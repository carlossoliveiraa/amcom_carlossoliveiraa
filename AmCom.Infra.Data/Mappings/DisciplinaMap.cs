using AmCom.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AmCom.Infra.Data.Mappings
{
    public class DisciplinaMap : MapBase<Disciplina>
    {
        public override void Configure(EntityTypeBuilder<Disciplina> builder)
        {
            base.Configure(builder);
            builder.ToTable("Disciplinas");
            builder.Property(c => c.Descricao).HasColumnName("Descricao");           
            builder.Property(c => c.DataCadastro).IsRequired().HasColumnName("DataCadastro");
            builder.Property(c => c.DataAlteracao).HasColumnName("DataAlteracao");
            builder.Property(c => c.Ativo).HasColumnName("Ativo");
        }
    }
}

