using Conexao.Domain.Domain;
using MinhaPrimeiraConexao.data;
using System.Collections.Generic;
using System.Linq;

namespace MinhaPrimeiraConexao.Data.Repositorio
{
    public class TurmaRepository 

        {
            public readonly Context contexto;

            public TurmaRepository()
            { 
                contexto = new Context();
            }

            public void Incluir(Turma turma)
            {
                contexto.Turma.Add(turma);
                contexto.SaveChanges();
            }
            public Turma Selecionar(int id)
            {
                return contexto.Turma.FirstOrDefault(x => x.Id == id);
            }
            public List<Turma> SelecionarTudo()
            {
                return contexto.Turma.ToList();
            }
            public void Alterar(Turma turma)
            {
                contexto.Turma.Update(turma);
                contexto.SaveChanges();
            }

            public void Excluir(int id)
            {
                var turma = Selecionar(id);
                contexto.Turma.Remove(turma);
            }
        }
}

