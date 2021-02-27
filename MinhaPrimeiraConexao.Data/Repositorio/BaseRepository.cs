using Abp.Domain.Entities;
using MinhaPrimeiraConexao.data;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;

namespace MinhaPrimeiraConexao.Data.Repositorio
{
    public class BaseRepository<T> where T: class, IEntity
    {
        protected readonly Context contexto;
        public BaseRepository()
        {
            contexto = new Context();
        }
        public void Incluir(T entity)
            {
            contexto.Set<T>().Add(entity);
            contexto.SaveChanges();
            }
        public void Alterar (T entity)
        {
            contexto.Set<T>().Update(entity);
            contexto.SaveChanges();
        }
        public T Selecionar(int id)
        {
            return contexto.Set<T>().FirstOrDefault(x => x.Id == id);
        }

        public void Excluir(int id)
        {
            var entity = Selecionar(id);
            contexto.Set<T>().Remove(entity);
            contexto.SaveChanges();
        }

        public List<T> SelecionarTudo()
        {
            return contexto.Set<T>().ToList();
        }
    }
}
