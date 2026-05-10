using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaExpedientesV2.Data;
using SistemaExpedientesV2.Models;

namespace SistemaExpedientesV2.Controllers
{
    public class ReportesController : Controller
    {
        private readonly AppDbContext _context;

        public ReportesController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Promedios()
        {
            var promedios = await _context.Expedientes
                .Include(e => e.Alumno)
                .GroupBy(e => new
                {
                    e.AlumnoId,
                    e.Alumno.Nombre,
                    e.Alumno.Apellido
                })
                .Select(g => new PromedioAlumno
                {
                    NombreCompleto = g.Key.Nombre + " " + g.Key.Apellido,
                    Promedio = g.Average(x => x.NotaFinal)
                })
                .ToListAsync();

            return View(promedios);
        }
    }
}