using Microsoft.EntityFrameworkCore;
using Conexao.Domain;
using MinhaPrimeiraConexao.Data.Map;
using Conexao.Domain.Domain;
using Conexao.Domain.Models;
using MinhaPrimeiraConexao.Data.Repositorio;

namespace MinhaPrimeiraConexao.data
{
    public class Context : DbContext

    {
        public DbSet<Turma> Aluno { get; set; }
        public DbSet<Professor> Professor { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<Turma> Turma { get; set; }
        public DbSet<TurmaProfessor> TurmaProfessor { get; set; }
     

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            object p = optionsBuilder.UseSqlServer("Server=DESKTOP-0E2MGV9\\SQLEXPRESS; Database=MinhaConexao; Trusted_Connection=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlunoMap());
            modelBuilder.ApplyConfiguration(new ProfessorMap());
            modelBuilder.ApplyConfiguration(new TurmaMap());
            modelBuilder.ApplyConfiguration(new TurmaProfessorMap());
            modelBuilder.ApplyConfiguration(new DisciplinaMap());


            base.OnModelCreating(modelBuilder);
        }

    }
}
