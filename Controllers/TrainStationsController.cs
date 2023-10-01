using Microsoft.AspNetCore.Mvc;
using TrainStationsAPI.DataObjects;

namespace TrainStationsAPI.Controllers;


[ApiController]
[Route("[controller]")]
public class TrainStationsController : ControllerBase {
    
    private readonly ILogger<TrainStationsController> _logger;
    
    public TrainStationsController(ILogger<TrainStationsController> logger)
    {
        this._logger = logger;
    }
    
    
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult GetAllStations()
    {
        _logger.Log(LogLevel.Information, "Listando todas as estações cadastradas no sistema");
        return Ok("");
    }
    
    
    [HttpGet("{lineNumber}")]
    public IActionResult GetStationsByLine(int lineNumber)
    {
        return Ok();
    }
    
    [HttpPost("{lineNumber}")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public IActionResult AddStation(int lineNumber, StationDto station)
    {
        return Created("", null);
    }
    
    
    [HttpDelete("{lineNumber}/{stationCode}")]
    public IActionResult DeactivateStation(int lineNumber, string stationCode )
    {
        return NoContent();
    }
    
}