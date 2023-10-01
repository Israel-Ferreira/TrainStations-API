using Microsoft.AspNetCore.Mvc;
using TrainStationsAPI.Services;

namespace TrainStationsAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class LinesController : ControllerBase {
    
    private readonly ILineService _lineService;
    
    public LinesController(ILineService lineService)
    {
        _lineService =  lineService;
    }
    
    [HttpGet]
    public ActionResult ListAllLines()
    {
        var lines =  _lineService.ListarLinhas();
        return Ok(lines);
    }
    
    
    [HttpGet("{lineNumber}")]
    public ActionResult GetLineByNumber(int lineNumber)
    {
        var line = _lineService.GetLineByNumber(lineNumber);
        return Ok(line);
    }
    
}