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
      Book[] books = new Book[9];
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
      books[6] = new Book()
      {
        Title = "Clean Code",
        Author = "Uncle Bob",
        Description = "Uncle Bob teaches us how to write good code.",
        Cover = "https://images-na.ssl-images-amazon.com/images/I/41yafGMO+rL._SX258_BO1,204,203,200_.jpg",
        Status = "READING",
        Liked = true
      };
      books[7] = new Book()
      {
        Title = "H.P. Lovecraft - Medo Clássico - Vol. 1 - Cosmic Edition: O mestre dos mestres para todas as gerações",
        Author = "H.P. Lovecraft",
        Description = "lOVECRAFTIAN STUFF.",
        Cover = "https://images-na.ssl-images-amazon.com/images/I/51gfbN03iWL._SY344_BO1,204,203,200_QL70_ML2_.jpg",
        Status = "WANT TO READ",
        Liked = false
      };
      books[8] = new Book()
      {
        Title = "O macaco e a mola",
        Author = " Sônia Junqueira",
        Description = "First book I´ve ever read.",
        Cover = "https://images-na.ssl-images-amazon.com/images/I/41EZtzDsLbL._SX355_BO1,204,203,200_.jpg",
        Status = "FINISHED",
        Liked = true
      };
      database.Books.AddRange(books);
      database.SaveChanges();
    }
  }
}