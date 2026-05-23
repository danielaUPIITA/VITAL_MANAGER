using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VitalManager.API.Models;


namespace VitalManager.API.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        // DbSets existentes
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Personal> Personal { get; set; }
        //public DbSet<Rol> appRoles { get; set; }
        public DbSet<InsumoMedico> InsumosMedicos { get; set; }
        public DbSet<Espacio> Espacios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuración de tablas y schemas
            modelBuilder.Entity<Paciente>().ToTable("paciente", schema: "pacientes");
            modelBuilder.Entity<Personal>().ToTable("personal_medico", schema: "personal");
            modelBuilder.Entity<Rol>().ToTable("rol", schema: "roles");
            modelBuilder.Entity<InsumoMedico>().ToTable("insumo_medico", schema: "recursos");
            modelBuilder.Entity<Espacio>().ToTable("espacio", schema: "recursos");

            // Importante: llamar al base para que Identity configure sus tablas
            base.OnModelCreating(modelBuilder);
        }
    }
}
