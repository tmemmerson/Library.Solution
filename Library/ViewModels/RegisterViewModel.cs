using System.ComponentModel.DataAnnotations;

namespace Library.ViewModels
{
  public class RegisterViewModel
  {
    [Required]
    [EmailAddress]
    [Display(Name = "Email")]
    public string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    public string Password { get; set; }

    [DataType(DataType.Password)]
    [Display(nameof = "Confirm Password")]
    [Compare("Password", ErrorMessage = "The password and confirmation password do not match. You're better than that. Try harder.")]
    public string ConfirmPassword { get; set; }
  }
}