using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.Swift;

namespace MovieReviewWebsite.Models;

public class MovieReview
{
    [Key]
    [Required]
    public int Id { get; set; }
    public string rating { get; set; }
    public bool edited { get; set; }
    [MaxLength(25)]
    public string notes { get; set; }
    public string category { get; set; }
    public string title { get; set; }
    public string yearRange { get; set; }
    public string director { get; set; }
    public string lentTo { get; set; }
}