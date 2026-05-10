using System.ComponentModel.DataAnnotations;

namespace SistemaExpedientesV2.Models
{
    public class Materia
    {
        public int MateriaId { get; set; }

        [Required]
        public string NombreMateria { get; set; }

        public string Docente { get; set; }

        public ICollection<Expediente>? Expedientes { get; set; }
    }
}