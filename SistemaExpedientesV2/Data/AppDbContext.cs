using Microsoft.EntityFrameworkCore;
using SistemaExpedientesV2.Models;

namespace SistemaExpedientesV2.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Alumno> Alumnos { get; set; }

        public DbSet<Materia> Materias { get; set; }

        public DbSet<Expediente> Expedientes { get; set; }
    }
}