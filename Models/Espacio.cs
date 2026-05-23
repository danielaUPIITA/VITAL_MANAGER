using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VitalManager.API.Models
{
    [Table("espacio", Schema = "recursos")]
    public class Espacio
    {
        [Key]
        [Column("id_espacio")]
        public int IdEspacio { get; set; }

        [Column("tipo")]
        public string Tipo { get; set; } = string.Empty;

        [Column("disponible")]
        public bool Disponible { get; set; } = true;
    }
}
