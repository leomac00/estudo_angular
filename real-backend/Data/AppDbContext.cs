using Microsoft.EntityFrameworkCore;
using real_backend.Models;

namespace real_backend.Data
{
  public class AppDbContext : DbContext
  {
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Book> Books { get; set; }
  }
}