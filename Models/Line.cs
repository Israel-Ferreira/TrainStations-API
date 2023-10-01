using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainStationsAPI.Models;

public class Line {
    
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long LineId {get; set;}
    
    public int LineNumber {get; set;}
    public string? Color {get; set;}
    
    public double Extension {get; set;}
    
    public double Gauge {get; set;}
    
    public ICollection<TrainStation> Stations {get; }
    
    public string LineOperator {get; set;}
    
    public Line() {}
    
    public Line(int lineNumber, string color, double extension, double gauge, string lineOperator)
    {
        LineNumber = lineNumber;
        Color = color;
        Extension = extension;
        Gauge = gauge;
        Stations = new List<TrainStation>();
        LineOperator = lineOperator;
    }
}