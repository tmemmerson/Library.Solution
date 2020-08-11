using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Library.Models
{
  public class Patron : IdentityUser
  {
    public int PatronId { get; set; }
    public string Name { get; set; }
    
    public virtual ICollection<Checkout> Copies { get; }

  }
}