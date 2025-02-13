using Microsoft.EntityFrameworkCore;

namespace Mission6.Models
{
    public class MovieContext : DbContext
    {
        // Constructor to pass options to the base class (DbContext)
        public MovieContext(DbContextOptions<MovieContext> options) : base(options) { }

        // Define DbSets for each entity that will be mapped to a table in the database
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Rating> Ratings { get; set; }

        // Optionally, configure model relationships and seed data in OnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Action" },
                new Category { CategoryId = 2, Name = "Drama" },
                new Category { CategoryId = 3, Name = "Comedy" }
            );

            modelBuilder.Entity<Rating>().HasData(
                new Rating { RatingId = 1, Name = "G" },
                new Rating { RatingId = 2, Name = "PG" },
                new Rating { RatingId = 3, Name = "PG-13" },
                new Rating { RatingId = 4, Name = "R" }
            );
        }
    }
}