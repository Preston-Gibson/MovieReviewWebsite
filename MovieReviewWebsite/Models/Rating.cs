using System.ComponentModel.DataAnnotations;

namespace MovieReviewWebsite.Models;

public class Rating
{
    [Key]
    public int RatingId { get; set; }

    [Required]
    public string Name { get; set; }

    public ICollection<Movie> Movies { get; set; }
}