using SacramentPlanner.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        public DbSet<Program> Programs { get; set; }
        public DbSet<History> Histories { get; set; }
        //public DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Program>().ToTable("Program");
            modelBuilder.Entity<History>().ToTable("History");
            //modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}