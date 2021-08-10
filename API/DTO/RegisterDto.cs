using System.ComponentModel.DataAnnotations;

namespace API.DTO
{
  public class RegisterDto
  {
    // Data Annotations
    [Required]
    public string Username { get; set; }
    [Required]
    public string Password { get; set; }
  }
}