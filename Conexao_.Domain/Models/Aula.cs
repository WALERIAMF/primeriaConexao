
using System;
using System.Collections.Generic;


namespace Conexao.Domain.Domain
{
    public class Aula
    {
        public List<Turma> Aluno { get; set; }
        public string Professor { get; set; }
        public DateTime HoraInicioAula { get; set; }
        public DateTime HoraFimAula { get; set; }
        public Materia Materias { get; set; }
        public List<Turma> Turma { get; set; }

        public enum Materia
        {
            Biologia,
            Geografia,
            Matematica,
            Ingles,
            Portugues
        }
    }
}
