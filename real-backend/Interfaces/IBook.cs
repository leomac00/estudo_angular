namespace real_backend.Interfaces
{
  public interface IBook
  {
    int Id { get; set; }
    string Title { get; set; }
    string Author { get; set; }
    string Description { get; set; }
    string Cover { get; set; }
    string Status { get; set; }
    bool Liked { get; set; }
  }
}