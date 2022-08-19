using System.ComponentModel.DataAnnotations;

namespace ParksLookup.Models
{
  public class Park
  {
    public int ParkId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string State { get; set; }
    [Required]
    [StringLength(2)]
    public string StateAbbreviation { get; set; }
    [Required]
    public string Website { get; set; }
    public string Description { get; set; }
  }
}
