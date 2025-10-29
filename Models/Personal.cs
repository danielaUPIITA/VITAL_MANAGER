using System.ComponentModel.DataAnnotations.Schema;

namespace VitalManager.API.Models
{
    [Table("personal_medico", Schema = "personal")]
    public class Personal
    {
        [Column("id_personal")]
        public int Id { get; set; }

        [Column("nombre")]
        public string Nombre { get; set; }

        [Column("usuario")]
        public string Usuario { get; set; }

        [Column("password")]
        public string Password { get; set; }

        [Column("rol")]
        public string Rol { get; set; }
    }
}