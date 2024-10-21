using Microsoft.EntityFrameworkCore;
using Pratik___Survivor.Models;

namespace Pratik___Survivor.Data
{
    public class SurvivorContext:DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public DbSet<Competitor> Competitors { get; set; }

        public SurvivorContext(DbContextOptions<SurvivorContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Competitor>()
                        .HasOne(x => x.Category)
                        .WithMany(x => x.Competitors)
                        .HasForeignKey(x => x.CategoryId);
        }
    }
}
