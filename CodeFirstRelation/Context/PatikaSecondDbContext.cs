using CodeFirstRelation.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstRelation.Context
{
    public class PatikaSecondDbContext : DbContext
    {
        public DbSet<User> Users => Set<User>();
        public DbSet<Post> Posts => Set<Post>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                        .HasMany(x => x.Posts)
                        .WithOne(x => x.User);

            modelBuilder.Entity<Post>()
                        .HasOne(x => x.User)
                        .WithMany(x => x.Posts)
                        .HasForeignKey(x => x.UserId);

        }

    }
}
