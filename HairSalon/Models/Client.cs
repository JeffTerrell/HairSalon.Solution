namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Location {get; set; }
    public int StylistId { get; set; }
    public virtual Stylist Stylist { get; set; }
  }
}