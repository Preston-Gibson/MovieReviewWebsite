using System.ComponentModel.DataAnnotations;

namespace MovieReviewWebsite.Models;

public class Loan
{
    [Key]
    public int LoanId { get; set; }

    public int MovieId { get; set; }
    public Movie Movie { get; set; }

    [Required]
    public string LentTo { get; set; }

    public DateTime DateLent { get; set; } = DateTime.Now;
    public DateTime? DateReturned { get; set; }
}