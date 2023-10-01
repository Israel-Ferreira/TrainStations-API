using Microsoft.EntityFrameworkCore;
using TrainStationsAPI.Database;
using TrainStationsAPI.Models;

namespace TrainStationsAPI.Services;

public class LineService : ILineService
{
    private readonly TrainStationsContext  _dbContext;
    
    public LineService(TrainStationsContext context)
    {
        _dbContext =  context;
    }


    public IEnumerable<Line> ListarLinhas()
    {
        return _dbContext.Lines.ToList();
    }

    public IEnumerable<Line> ListLinesByOperator(string lineOperator)
    {
        throw new NotImplementedException();
    }

    public Line GetLineByColor(string color)
    {
        return _dbContext.Lines
                .FirstOrDefault(line => line.Color == color);
    }

    public Line GetLineByNumber(int lineNumber)
    {
        return _dbContext.Lines.FirstOrDefault(line => line.LineNumber == lineNumber);
    }

    public Line GetLineById(int lineId)
    {
        return _dbContext.Lines.Find(lineId);
    }
}