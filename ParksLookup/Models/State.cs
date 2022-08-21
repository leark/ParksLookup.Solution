using System.ComponentModel.DataAnnotations;

namespace ParksLookup.Models
{
  public class State
  {
    public int StateId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    [StringLength(2)]
    public string Abbr { get; set; }
  }
}
