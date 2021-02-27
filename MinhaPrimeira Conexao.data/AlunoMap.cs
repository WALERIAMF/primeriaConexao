using System;
using System.Collections.Generic;
using System.Text;

namespace MinhaPrimeira_Conexao.data
{
    public class AlunoMap:IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            buider.ToTable("Aluno");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome)
                .HasColumnType("varhar(150")
                .IsRequired();
            buider.Property(x => x.Ativo)
                .IsReuired();
        }
    }
}
