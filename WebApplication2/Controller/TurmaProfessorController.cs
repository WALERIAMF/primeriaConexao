using Conexao.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using MinhaPrimeiraConexao.Data.Repositorio;
using System.Collections.Generic;


namespace MinhaConexao.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurmaProfessorController : ControllerBase
    {

        private readonly TurmaProfessorRepository repo;

        public TurmaProfessorController()
        {
            repo = new TurmaProfessorRepository();
        }

        [HttpGet]
        public IEnumerable<TurmaProfessor> Get()
        {
            return repo.SelecionarTudoCompleto();
        }

        [HttpGet("{id}")]
        public TurmaProfessor Get(int id)
        {
            return repo.Selecionar(id);
        }

         // POST api/<ProfessorController>
        [HttpPost]
        public IEnumerable<TurmaProfessor> Post([FromBody] TurmaProfessor turmaProf)
        {
            repo.Incluir(turmaProf);

            return repo.SelecionarTudo();
        }

        // PUT api/<ProfessorController>/5
        [HttpPut]
        public IEnumerable<TurmaProfessor> Put(int id, [FromBody] TurmaProfessor turmaProf)
        {
            repo.Alterar(turmaProf);
            return repo.SelecionarTudo();
        }

        // DELETE api/<ProfessorController>/5
        [HttpDelete("{id}")]
        public IEnumerable<TurmaProfessor> Delete(int id)
        {
            repo.Excluir(id);
            return repo.SelecionarTudo();
        }
    }
}
