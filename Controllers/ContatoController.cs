using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using API_2.Entites;
using API_2.Contexts;

namespace API_2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {
        
        private readonly AgendaContext _context;
        public ContatoController(AgendaContext context){
            _context = context;
        }

        [HttpPost]
        public IActionResult Create(Contato contato){
            _context.Add(contato);
            _context.SaveChanges();
            return Ok(contato);
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id){
            var contato = _context.Contato.Find(id);
 
            if (id == null)
                return NotFound();

            return Ok(contato);
        }

        [HttpGet("ObterPorNome")]
        public IActionResult obterPorNome(string nome){
            var contatos = _context.Contato.Where(x => x.Nome.Contains(nome));
            return Ok(contatos);
        }

        [HttpPut("{id}")]
        public IActionResult Atualiza(int id, Contato contato){
            var contatoBanco = _context.Contato.Find(id);

            if (contatoBanco == null)
                return NotFound();

            contatoBanco.Nome = contato.Nome;
            contatoBanco.Telefone = contato.Telefone;
            contatoBanco.Ativo = contato.Ativo;

            _context.Contato.Update(contatoBanco);
            _context.SaveChanges();

            return Ok(contatoBanco);

        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var contatoBanco = _context.Contato.Find(id);

            if (contatoBanco == null)
                return NotFound();

            _context.Contato.Remove(contatoBanco);
            _context.SaveChanges();
            return NoContent();
        }
    }
}