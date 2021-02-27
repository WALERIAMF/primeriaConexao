using Conexao.Domain.Models;
using System;
using System.Collections.Generic;
using Abp.Domain.Entities;

namespace Conexao.Domain.Domain
{
    public class Turma : IEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Horario Horarios { get; set; }
        public List<TurmaProfessor>TurmaProfessor { get; set; }
        public Materia Materias { get; set; }


        public enum Materia
        {
            Biologia,
            Geografia,
            Matematica,
            Ingles,
            Portugues
        }
        public enum Horario
        {
            Manha,
            Tarde,
            Noite,
            Integral
        }

    }
}

