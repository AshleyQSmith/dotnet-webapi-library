
using System.ComponentModel.DataAnnotations;

namespace dotnet_webapi_library.Models
{
  public class Library
  {
    public int Id { get; set; }
    [Required]
    [MaxLength(30)]
    public string Name { get; set; }
    public string Location { get; set; }

  }
}