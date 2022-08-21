using System.ComponentModel.DataAnnotations;

namespace ParksLookup.Models
{
  public class Park
  {
    public int ParkId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Website { get; set; }
    [Required]
    public bool StatePark { get; set; }
    [Required]
    public int StateId { get; set; }
    public string Description { get; set; }
    public virtual State State { get; set; }
  }
}
