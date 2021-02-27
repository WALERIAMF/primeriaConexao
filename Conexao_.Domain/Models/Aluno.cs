
using Abp.Domain.Entities;
using Conexao.Domain.Models;
using System.Collections.Generic;

namespace Conexao.Domain.Domain
{
    public class Aluno : Entity
    {
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public decimal Nota { get; set; }
        public bool Aprovacao { get; set; }
    }
}