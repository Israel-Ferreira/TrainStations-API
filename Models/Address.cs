using System.ComponentModel.DataAnnotations.Schema;

namespace TrainStationsAPI.Models;


public class Address {

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id {get; set;}

    public string? PublicPlace {get; set;}
    public string? AddressNumber {get; set;}
    
    public string? Neighbourhood {get; set;}
    
    public string? City {get; set;}
    public string? Uf {get; set;}

    public string? Zipcode {get; set;}
}