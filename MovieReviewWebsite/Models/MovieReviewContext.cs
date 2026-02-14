using Microsoft.EntityFrameworkCore;

namespace MovieReviewWebsite.Models;

public class MovieReviewContext : DbContext
{
    public MovieReviewContext(DbContextOptions<MovieReviewContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MovieDirector>()
            .HasKey(md => new { md.MovieId, md.DirectorId });
    }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Rating> Ratings { get; set; }
    public DbSet<Director> Directors { get; set; }
    public DbSet<MovieDirector> MovieDirectors { get; set; }
    public DbSet<Loan> Loans { get; set; }
}