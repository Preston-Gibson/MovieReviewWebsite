using System.ComponentModel.DataAnnotations;

namespace MovieReviewWebsite.Models;

public class Director
{
    [Key]
    public int DirectorId { get; set; }

    [Required]
    public string Name { get; set; }

    public ICollection<MovieDirector> MovieDirectors { get; set; }
}