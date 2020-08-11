using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Library.Models
{
  public class LibraryContext : IdentityDbContext<Patron>
  {
    public virtual DbSet<Author> Authors { get; set; }
    public virtual DbSet<Book> Books { get; set; }
    public virtual DbSet<AuthorBook> AuthorBook {get; set; }
    public virtual DbSet<Copy> Copies { get; set; }
    public virtual DbSet<Checkout> Checkouts { get; set; }

    public LibraryContext(DbContextOptions options) : base(options) {}
  }
}