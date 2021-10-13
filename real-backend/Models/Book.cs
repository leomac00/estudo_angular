using real_backend.Interfaces;

namespace real_backend.Models
{
  public class Book : IBook
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Description { get; set; }
    public string Cover { get; set; }
    public string Status { get; set; }
    public bool Liked { get; set; }
    
  }
}