using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class SchoolDBCOntext : DbContext
    {
        public SchoolDBCOntext(DbContextOptions options) : base(options) { }

        public DbSet<School> Schools { get; set; }
        public DbSet<Muncipality> Municipalities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Muncipality>().HasKey(m => m.Id);
            modelBuilder.Entity<School>().HasKey(s => s.Id);
            modelBuilder.Entity<Muncipality>().HasMany(m => m.Schools);
            modelBuilder.Entity<School>()
                .HasOne(s => s.Muncipality)
                .WithMany(m => m.Schools)
                .HasForeignKey(s => s.MuncipalityId);
        }
    }
}
