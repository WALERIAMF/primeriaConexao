
/*using Conexao.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace MinhaPrimeiraConexao.Data.Repositorio
{
    public class TurmaProfessorRepository : BaseRepository<TurmaProfessor>
    {
        public List<TurmaProfessor> SelecionarTudoCompleto()
        {
            return contexto.TurmaProfessor
                .Include(x => x.Professor)
                .Include(x => x.Turma)
                .ToList();
        }

        public override void Incluir(TurmaProfessor entity)
        {
            // colocar regras para inclusao


            base.Incluir(entity);
        }
    }
}*/

