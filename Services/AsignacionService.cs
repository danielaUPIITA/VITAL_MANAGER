using VitalManager.API.Data;
using VitalManager.API.Models;

namespace VitalManager.API.Services
{
    public class AsignacionService
    {
        private readonly ApplicationDbContext _context;

        public AsignacionService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AsignarEspacio(int prioridadFinal)
        {
            string tipoEspacio;

            if (prioridadFinal >= 10)
                tipoEspacio = "Sala de choque";
            else if (prioridadFinal >= 6)
                tipoEspacio = "Consultorio";
            else
                tipoEspacio = "Cama general";

            var espacio = _context.Espacios.FirstOrDefault(e => e.Tipo == tipoEspacio && e.Disponible);
            if (espacio != null)
            {
                espacio.Disponible = false;
                _context.SaveChanges();
            }
        }

        public IEnumerable<object> ResumenDisponibilidad()
        {
            return _context.Espacios
                .GroupBy(e => e.Tipo)
                .Select(g => new {
                    Tipo = g.Key,
                    Total = g.Count(),
                    Libres = g.Count(e => e.Disponible),
                    Ocupados = g.Count(e => !e.Disponible)
                })
                .ToList();
        }
    }
}
