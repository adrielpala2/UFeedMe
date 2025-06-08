using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UFeedMeApi.Data;
using UFeedMeApi.Models;

namespace UFeedMeApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AvaliacoesController : ControllerBase
    {
        private readonly UFeedMeContext _context;

        public AvaliacoesController(UFeedMeContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() =>
            Ok(await _context.Avaliacoes.ToListAsync());

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Avaliacao avaliacao)
        {
            _context.Avaliacoes.Add(avaliacao);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetAll), new { id = avaliacao.Id }, avaliacao);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Avaliacao nova)
        {
            var existente = await _context.Avaliacoes.FindAsync(id);
            if (existente == null) return NotFound();

            existente.Email = nova.Email;
            existente.Exposicao_Escolhida = nova.Exposicao_Escolhida;
            existente.Opiniao = nova.Opiniao;
            existente.Sugestao = nova.Sugestao;

            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var existente = await _context.Avaliacoes.FindAsync(id);
            if (existente == null) return NotFound();

            _context.Avaliacoes.Remove(existente);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
