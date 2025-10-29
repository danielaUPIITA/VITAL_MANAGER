using Microsoft.EntityFrameworkCore;
using VitalManager.API.Models;

namespace VitalManager.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Personal> Personal { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<InsumoMedico> InsumosMedicos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuración de tablas y schemas
            modelBuilder.Entity<Paciente>().ToTable("paciente", schema: "pacientes");
            modelBuilder.Entity<Personal>().ToTable("personal_medico", schema: "personal");
            modelBuilder.Entity<Rol>().ToTable("rol", schema: "roles");
            modelBuilder.Entity<InsumoMedico>().ToTable("insumo_medico", schema: "recursos");

            base.OnModelCreating(modelBuilder);
        }
    }
}
