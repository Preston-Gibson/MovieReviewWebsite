using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.Swift;

namespace MovieReviewWebsite.Models;

public class Movie
{
    [Key]
    public int MovieId { get; set; }

    [Required]
    public string Title { get; set; }

    public string Year { get; set; }
    
    public string Notes { get; set; }

    public bool? Edited { get; set; }

    // Foreign Keys
    public int CategoryId { get; set; }
    public Category Category { get; set; }

    public int RatingId { get; set; }
    public Rating Rating { get; set; }

    // Navigation
    public ICollection<MovieDirector> MovieDirectors { get; set; }
    public ICollection<Loan> Loans { get; set; }
}