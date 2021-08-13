using System.ComponentModel.DataAnnotations;

namespace API.DTO
{
  public class RegisterDto
  {
    // Data Annotations
    [Required]
    public string Username { get; set; }
    [Required]
    [StringLength(8, MinimumLength = 4)]
    public string Password { get; set; }
  }
}