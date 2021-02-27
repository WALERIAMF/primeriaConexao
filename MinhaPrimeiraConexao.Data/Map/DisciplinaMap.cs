using Conexao.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace MinhaPrimeiraConexao.Data.Map
{
    public class DisciplinaMap : IEntityTypeConfiguration<Disciplina>
        {

        public void Configure(EntityTypeBuilder<Disciplina> builder)
        {
            builder.ToTable("Disciplina");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Descricao)
                .HasColumnType("varchar(150)")
                .IsRequired();

        }
    }
}
