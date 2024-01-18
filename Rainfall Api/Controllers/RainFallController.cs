using Microsoft.AspNetCore.Mvc;
using RainfallApi.Services.Interface;

namespace Rainfall_Api.Controllers;

[Route("sorted")]
[ApiController]
public class RainFallController : ControllerBase
{
    private readonly IFloodService _floodService;
    public RainFallController(IFloodService floodService) =>
        _floodService = floodService;

    [HttpGet("/rainfall")]
    public async Task<IActionResult> GetAllFloodData(CancellationToken cancellationToken)
    {
        var data = await _floodService.GetAllFlood(cancellationToken);
        return Ok(data);
    }

    [HttpGet("/rainfall/id/{stationId}/readings")]
    public async Task<IActionResult> GetStationID(string stationID, CancellationToken cancellationToken)
    {
        var data = await _floodService.GetStationId(stationID, cancellationToken);
        return Ok(data);
    }
}