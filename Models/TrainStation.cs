namespace TrainStationsAPI.Models;

public class TrainStation {
    
    public int TrainStationId {get; set;}
    public string? Name { get; set; }
    
    public string? Code { get; set; }
    
    public int OpeningYear {get; set;}
    
    public double Latitude {get; set;}
    
    public double Longitude {get; set;}
    
    public ICollection<Line> Lines {get; }
    
    public Address StationAddress {get; set;}
    
    public TrainStation() => Lines = new List<Line>();
}