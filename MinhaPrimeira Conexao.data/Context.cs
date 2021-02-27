using Microsoft.EntityFrameworkCore;
using System;
using MinhaPrimeiraConexao.data;
using Conexao.Domain;

namespace MinhaPrimeiraConexao.data
{
    public class Context : DbContext

    {
        private DbSet<Aluno> Aluno { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            object p = optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database = MinhaConexao;Trusted_Connection=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlunoMap());
            base.OnModelCreating(modelBuilder);
        }


    }
}
