using System.ComponentModel.DataAnnotations.Schema;

namespace VitalManager.API.Models
{
    [Table("insumo_medico", Schema = "recursos")]
    public class InsumoMedico
    {
        [Column("id_insumo")]
        public int Id { get; set; }

        [Column("nombre")]
        public string Nombre { get; set; }

        [Column("descripcion")]
        public string Descripcion { get; set; }

        [Column("cantidad")]
        public int Cantidad { get; set; }

        [Column("fecha_caducidad")]
        public DateTime FechaCaducidad { get; set; }
    }
}