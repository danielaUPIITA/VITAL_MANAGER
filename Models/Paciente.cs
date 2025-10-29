using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace VitalManager.API.Models
{
    [Table("paciente", Schema = "pacientes")]
    public class Paciente
    {
        [Column("id_paciente")]
        public int Id { get; set; }

        [Column("nombre")]
        public string Nombre { get; set; }

        [Column("fecha_nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [Column("telefono")]
        public string Telefono { get; set; }

        [Column("direccion")]
        public string Direccion { get; set; }
    }
}