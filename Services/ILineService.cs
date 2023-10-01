using TrainStationsAPI.Models;

namespace TrainStationsAPI.Services;

public interface ILineService {
    IEnumerable<Line> ListarLinhas();
    IEnumerable<Line> ListLinesByOperator(string lineOperator);
    
    Line GetLineByColor(string color);
    Line GetLineByNumber(int lineNumber);
    
    Line GetLineById(int lineId);
}