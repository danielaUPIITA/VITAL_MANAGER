using Microsoft.AspNetCore.Mvc;
using VitalManager.API.Models;
using VitalManager.API.Data;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using VitalManager.API.Services;


namespace VitalManager.API.Controllers
{
    [ApiController]
    [Route("api/espacios")]
    public class EspaciosController : ControllerBase
    {
        private readonly AsignacionService _service;

        public EspaciosController(AsignacionService service)
        {
            _service = service;
        }

        [HttpPost("asignar/{prioridad}")]
        public IActionResult Asignar(int prioridad)
        {
            _service.AsignarEspacio(prioridad);
            return Ok("Espacio asignado correctamente.");
        }

        [HttpGet("resumen")]
        public IActionResult GetResumen()
        {
            return Ok(_service.ResumenDisponibilidad());
        }
    }
}
