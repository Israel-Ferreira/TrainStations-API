using Microsoft.AspNetCore.Mvc;
using TrainStationsAPI.DataObjects;
using TrainStationsAPI.Exceptions;
using TrainStationsAPI.Models;
using TrainStationsAPI.Services;

namespace TrainStationsAPI.Controllers;


[ApiController]
[Route("[controller]")]
public class TrainStationsController : ControllerBase {
    
    private readonly ILogger<TrainStationsController> _logger;
    private readonly ITrainStationService _trainStationService;
    
    public TrainStationsController(ILogger<TrainStationsController> logger, ITrainStationService trainStationService)
    {
        this._logger = logger;
        _trainStationService = trainStationService;
    }
    
    
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public ActionResult<IEnumerable<TrainStation>> GetAllStations()
    {
        _logger.Log(LogLevel.Information, "Listando todas as estações cadastradas");
        var stations = _trainStationService.ListAllStations();
        return Ok(stations);
    }
    
    
    [HttpGet("{lineNumber}")]
    public ActionResult<IEnumerable<TrainStation>> GetStationsByLine(int lineNumber)
    {
        var stations =  _trainStationService.ListAllLineStations(lineNumber);
        return Ok(stations);
    }
    
    [HttpPost("{lineNumber}")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<IActionResult> AddStation(int lineNumber, StationDto station)
    {
        try
        {
            await _trainStationService.AdicionarEstacao(lineNumber, station);
            return Created("", null);
        }catch(LineNotFoundException lineNotFoundException)
        {
            return NotFound();
        }catch(Exception exception)
        {
            return UnprocessableEntity();
        }

    }
    
    
    [HttpDelete("{lineNumber}/{stationCode}")]
    public IActionResult DeactivateStation(int lineNumber, string stationCode )
    {
        return NoContent();
    }
    
}