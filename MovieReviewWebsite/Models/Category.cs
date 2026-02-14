using System.ComponentModel.DataAnnotations;

namespace MovieReviewWebsite.Models;

public class Category
{
    [Key]
    public int CategoryId { get; set; }

    [Required]
    public string Name { get; set; }

    public ICollection<Movie> Movies { get; set; }
}