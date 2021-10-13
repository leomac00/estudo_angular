using System.Linq;
using real_backend.Models;
namespace real_backend.Data
{
  public class SeedingService
  {
    private readonly AppDbContext database;
    public SeedingService(AppDbContext db)
    {
      this.database = db;
    }
    public void Seed()
    {
      if (database.Books.Any()) return;
      Book[] books = new Book[6];
      books[0] = new Book()
      {
        Title = "Name of the wind",
        Author = "Patrick Rothfuss",
        Description = "Youg Kvothe goes on adventure and learns magic",
        Cover = "https://m.media-amazon.com/images/I/51PZj2tdTGL.jpg",
        Status = "FINISHED",
        Liked = true
      };
      books[1] = new Book()
      {
        Title = "Elantris",
        Author = "Brandon Sanderson",
        Description = "Three people arrive in Arelon and one is stranded in cursed city because he´s cursed",
        Cover = "https://m.media-amazon.com/images/I/51vXa1V2pbL._SY346_.jpg",
        Status = "READING",
        Liked = true
      };
      books[2] = new Book()
      {
        Title = "The Hobbit",
        Author = "J. R. R. Tolkien",
        Description = "A bunch of tiny people goes on journey to pillage gold from dickhead dragon",
        Cover = "https://m.media-amazon.com/images/I/41e9fYrZ7oL._SY346_.jpg",
        Status = "FINISHED",
        Liked = true
      };
      books[3] = new Book()
      {
        Title = "Batman: Year One",
        Author = "Frank Miller",
        Description = "Bruce wayne gets beaten up until he learns how to be batman",
        Cover = "https://m.media-amazon.com/images/I/41F58rFCMwL.jpg",
        Status = "FINISHED",
        Liked = true
      };
      books[4] = new Book()
      {
        Title = "Harry Potter and the Sorcerer´s Stone",
        Author = "J. K. Rowling",
        Description = "Young harry potter searching for magic rock. Snape is innocent.",
        Cover = "https://m.media-amazon.com/images/I/51UoqRAxwEL._SY346_.jpg",
        Status = "FINISHED",
        Liked = true
      };
      books[5] = new Book()
      {
        Title = "Calculus",
        Author = "James Stewart",
        Description = "Good old james teach us how dumb we are using math.",
        Cover = "https://m.media-amazon.com/images/I/41c4OJNuZPL.jpg",
        Status = "WANT TO READ",
        Liked = false
      };
      database.Books.AddRange(books);
      database.SaveChanges();
    }
  }
}