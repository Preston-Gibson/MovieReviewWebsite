using System.Runtime.InteropServices.Swift;

namespace MovieReviewWebsite.Models;

public class MovieReview
{
    public string rating { get; set; }
    public bool edited { get; set; }
    public string notes { get; set; }
}