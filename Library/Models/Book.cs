using System.Collections.Generic;

namespace Library.Models
{
  public class Book
  {
    public Book()
    {
      this.Authors = new HashSet<AuthorBook>();
    }

    public int BookId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<AuthorBook> Authors { get; }
  }
}