
using Conexao.Domain.Domain;
using Microsoft.AspNetCore.Mvc;
using MinhaPrimeiraConexao.Data.Repositorio;
using System.Collections.Generic;



namespace MinhaConexao.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurmaController : ControllerBase
    {
        private readonly TurmaRepository repo;

        public TurmaController()
        {
            repo = new TurmaRepository();


        }
        // GET: api/<ProfessorController>

        [HttpGet]
        public IEnumerable<Turma> Get()
        {
            return repo.SelecionarTudo();
        }

        // GET api/<ProfessorController>/5
        [HttpGet("{id}")]
        public Turma Get(int id)
        {
            return repo.Selecionar(id);
        }

         // POST api/<ProfessorController>
        [HttpPost]
        public IEnumerable<Turma> Post([FromBody] Turma turma)
        {
            repo.Incluir(turma);

            return repo.SelecionarTudo();
        }

        // PUT api/<ProfessorController>/5
        [HttpPut]
        public IEnumerable<Turma> Put(int id, [FromBody] Turma turma)
        {
            repo.Alterar(turma);
            return repo.SelecionarTudo();
        }

        // DELETE api/<ProfessorController>/5
        [HttpDelete("{id}")]
        public IEnumerable<Turma> Delete(int id)
        {
            repo.Excluir(id);
            return repo.SelecionarTudo();
        }
    }
}
