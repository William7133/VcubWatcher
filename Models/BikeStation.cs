using System.Text.Json.Serialization;

namespace VclubWatcher.Models
{
  public class BikeStation
  {
    private BikeStation bikeStation;

    public BikeStation(BikeStation bikeStation)
    {
      this.bikeStation = bikeStation;
    }

    public int id { get; set; }
    public string name { get; set; }
    public int bike_count { get; set; }
    public int electric_bike_count { get; set; }
    public int bike_count_total { get; set; }
    public int slot_count { get; set; }
    public bool is_online { get; set; }
    public int latitude { get; set; }
    public int longitude { get; set; }
    
  }
  
}
