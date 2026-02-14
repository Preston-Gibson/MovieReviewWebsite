using Microsoft.EntityFrameworkCore;

namespace MovieReviewWebsite.Models;

public class MovieReviewContext : DbContext
{
    public MovieReviewContext(DbContextOptions<MovieReviewContext> options) : base(options)
    {
    }
    
    public DbSet<MovieReview> MovieReviews { get; set; }
}