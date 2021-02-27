
using Conexao.Domain.Models;
using System.Collections.Generic;

namespace Conexao.Domain.Domain
{
    public class Professor : IEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Email { get; set; }
        public string Cargo { get; set; }
        public string Especializacao { get; set; }
        public Turno Turno { get; set;  }
        public List<TurmaProfessor> TurmaProfessor { get; set; }

    }

    public enum Turno
    {
        Manha,
        Tarde,
        Noite,
        Integral
    }
}
