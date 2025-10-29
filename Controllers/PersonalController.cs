using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VitalManager.API.Data;
using VitalManager.API.Models;

namespace VitalManager.API.Controllers
{
    [ApiController]
[Route("api/[controller]")]
public class PersonalController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public PersonalController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<ActionResult<Personal>> PostPersonal(Personal personal)
    {
        _context.Personal.Add(personal);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetPersonal), new { id = personal.Id }, personal);
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Personal>>> GetPersonal()
    {
        return await _context.Personal.ToListAsync();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePersonal(int id)
    {
        var personal = await _context.Personal.FindAsync(id);
        if (personal == null)
        {
            return NotFound();
        }

        _context.Personal.Remove(personal);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}
}