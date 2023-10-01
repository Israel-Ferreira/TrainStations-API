using System.ComponentModel.DataAnnotations;

namespace TrainStationsAPI.DataObjects;


public class StationDto {
    
    [Required(ErrorMessage = "O Nome da estação é um campo obrigatório")]
    public string? Name {get; set;}
    
    [Required(ErrorMessage = "A Latitude da estação é um campo obrigatório")]
    public string? Latitude {get; set;}
    

    [Required(ErrorMessage = "O Ano de Inaguração da e  stação é um campo obrigatório")]
    public int OpeningYear {get; set;}

    [Required(ErrorMessage = "A Longitude da estação é um campo obrigatório")]
    public string? Longitude {get; set;}
    
    [Required(ErrorMessage = "publicplace é um campo obrigatório")]
    public string? PublicPlace {get; set;}
    
    [Required(ErrorMessage = "O Cep da estação é um campo obrigatório")]
    public string? ZipCode {get; set;}
    
    public string? AddressNumber {get; set;}

    [Required(ErrorMessage = "O Cep da estação é um campo obrigatório")]
    public string? Neighbourhood {get; set;}
    
    [Required(ErrorMessage = "Cidade é um campo obrigatório")]
    public string? City {get; set;}
    
    [Required(ErrorMessage = "Uf é um campo obrigatório")]
    public string? Uf {get; set;}
    
    public StationDto()
    {
        
    }
    
}