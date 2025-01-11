using Microsoft.EntityFrameworkCore;
using POLICLINICA_HOPE_.Models; // Importă namespace-ul claselor din Models
using System.IO; // Import pentru Path și FileSystem

namespace POLICLINICA_HOPE_.Data
{
    public class AppDbContext : DbContext
    {
        // DbSet pentru Pacienti
        public DbSet<Pacient> Pacienti { get; set; }

        // DbSet pentru Medici
        public DbSet<Medic> Medici { get; set; }

        // DbSet pentru Departamente
        public DbSet<Departament> Departamente { get; set; }

        // Configurarea bazei de date
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Creează calea către baza de date folosind FileSystem.AppDataDirectory
            var dbPath = Path.Combine(FileSystem.AppDataDirectory, "app.db");

            // Configurarea SQLite cu calea bazei de date
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }

        // Configurare suplimentară pentru entități (dacă este necesară)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Exemplu de configurare pentru relații sau constrângeri (dacă sunt necesare)
            // modelBuilder.Entity<Medic>()
            //     .HasMany(m => m.Departamente)
            //     .WithOne()
            //     .HasForeignKey(d => d.MedicId);
        }
    }
}
