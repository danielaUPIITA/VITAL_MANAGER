using Microsoft.AspNetCore.Mvc;
using VitalManager.API.Models;
using VitalManager.API.Data;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace VitalManager.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InsumosMedicosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public InsumosMedicosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // 🔓 Acceso libre (puedes protegerlo si lo deseas)
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InsumoMedico>>> GetInsumos()
        {
            return await _context.InsumosMedicos.ToListAsync();
        }

        // Solo Enfermera puede registrar insumos
        [Authorize(Roles = "JefaEnfermeras")]
        [HttpPost]
        public async Task<ActionResult<InsumoMedico>> PostInsumo(InsumoMedico insumo)
        {
            insumo.FechaCaducidad = DateTime.SpecifyKind(insumo.FechaCaducidad, DateTimeKind.Utc);
            _context.InsumosMedicos.Add(insumo);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetInsumos), new { id = insumo.Id }, insumo);
        }

        // Solo Jefa de Enfermeras puede eliminar insumos
        [Authorize(Roles = "JefaEnfermeras")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInsumo(int id)
        {
            var insumo = await _context.InsumosMedicos.FindAsync(id);
            if (insumo == null)
            {
                return NotFound();
            }

            _context.InsumosMedicos.Remove(insumo);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}