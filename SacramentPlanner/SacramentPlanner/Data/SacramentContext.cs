using SacramentPlanner.Models;
using Microsoft.EntityFrameworkCore;

namespace SacramentPlanner.Data
{
    public class SacramentContext : DbContext
    {
        public SacramentContext(DbContextOptions<SacramentContext> options) : base(options)
        {
        }

        public DbSet<SacramentProgram> Programs { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<Member> Members { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SacramentProgram>().ToTable("Program");
            modelBuilder.Entity<History>().ToTable("History");
            modelBuilder.Entity<Member>().ToTable("Members");
        }
    }
}