using Ders6.EF.Models;
using Microsoft.EntityFrameworkCore;

namespace Ders6.EF.Data
{
    public class ApplicationDbContext:DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }


        public DbSet<Person> Person { get; set; }
        public DbSet<Job> Job { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Job>(e => e.Property(a => a.Aciklama).HasColumnName("Description"));
        }


    }
}
