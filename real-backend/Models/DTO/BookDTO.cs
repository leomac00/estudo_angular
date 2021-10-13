using System.ComponentModel.DataAnnotations;

namespace real_backend.Models.DTO
{
  public class BookDTO
  {
    [Required(ErrorMessage = "Book title is mandatory.")]
    [StringLength(200, MinimumLength = 3, ErrorMessage = "Book´s name should be beetwen {2} and {1} characters.")]
    public string Title { get; set; }
    [Required(ErrorMessage = "Book author is mandatory.")]
    [StringLength(200, MinimumLength = 3, ErrorMessage = "Book´s author should be beetwen {2} and {1} characters.")]
    public string Author { get; set; }
    [Required(ErrorMessage = "Book Description is mandatory.")]
    [StringLength(200, MinimumLength = 3, ErrorMessage = "Book´s Description should be beetwen {2} and {1} characters.")]
    public string Description { get; set; }
    [Required(ErrorMessage = "Book cover is mandatory.")]
    public string Cover { get; set; }
    [Required(ErrorMessage = "Book status is mandatory.")]
    public string Status { get; set; }
    [Required(ErrorMessage = "Book like status is mandatory.")]
    public bool Liked { get; set; }
  }
}