using SistemaExpedientesV2.Models;

namespace SistemaExpedientesV2.Models
{
    public class Expediente
    {
        public int ExpedienteId { get; set; }

        // FK Alumno
        public int AlumnoId { get; set; }
        public Alumno? Alumno { get; set; }

        // FK Materia
        public int MateriaId { get; set; }
        public Materia? Materia { get; set; }

        public decimal NotaFinal { get; set; }

        public string? Observaciones { get; set; }
    }
}