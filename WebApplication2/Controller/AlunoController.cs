using Conexao.Domain;
using Conexao.Domain.Domain;
using Microsoft.AspNetCore.Mvc;
using MinhaPrimeiraConexao.Data.Repositorio;
using System.Collections.Generic;


namespace Minha1Conexao.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly AlunoRepository repo;

        public AlunoController()
        {
            repo = new AlunoRepository();
        }

        [HttpGet]
        public IEnumerable<Aluno> Get()
        {
            return repo.SelecionarTudo();
        }

        [HttpGet("{id}")]
        public Aluno Get(int id)
        {
            return repo.Selecionar(id);
        }

        [HttpPost]
        public IEnumerable<Aluno> Post([FromBody] Aluno aluno)
        {
            repo.Incluir(aluno);

            return repo.SelecionarTudo();
        }
        [HttpPut("{id}")]
        public IEnumerable<Aluno> Put(int id, [FromBody] Aluno aluno)
        {
            repo.Alterar(aluno);
            return repo.SelecionarTudo();
        }

        [HttpDelete("{id}")]
        public IEnumerable<Aluno> Delete(int id)
        {
            repo.Excluir(id);
            return repo.SelecionarTudo();
        }
    }
}

