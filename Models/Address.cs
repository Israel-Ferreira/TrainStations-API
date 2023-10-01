namespace TrainStationsAPI.Models;

public class Address {
    public long Id {get; set;}
    public string? PublicPlace {get; set;}
    public string? AddressNumber {get; set;}
    
    public string? Neighbourhood {get; set;}
    
    public string? City {get; set;}
    public string? Uf {get; set;}
}