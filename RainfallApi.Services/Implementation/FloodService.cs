using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using RainfallApi.Services.Interface;
using RainfallApi.Services.Model;

namespace RainfallApi.Services.Implementation;
public class FloodService : IFloodService
{
    private readonly RainFallSettings _rainFallSettings;
    private readonly HttpClient _httpClient;
    public FloodService(IOptions<RainFallSettings> rainFallSettings, HttpClient httpClient)
    {      
        _rainFallSettings = rainFallSettings.Value;
        _httpClient = httpClient;
    }

    public async Task<FloodCollection> GetAllFlood(CancellationToken cancellationToken)
    {

        var root = _rainFallSettings.Root;
        var url = string.Concat(root, "/id/stations?parameter=rainfall");
        var response = await _httpClient.GetAsync(url);

        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<FloodCollection>(content);
            return data ?? new FloodCollection();
        }

        return new FloodCollection();
    }

    public async Task<ReadingsCollection> GetStationId(string stationID,CancellationToken cancellationToken)
    {
        var root = _rainFallSettings.Root;
        var url = string.Concat(root, $"/id/stations/{stationID}/readings");
     
        var response = await _httpClient.GetAsync(url);

        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<ReadingsCollection>(content);
            return data ?? new ReadingsCollection();
        }

        return new ReadingsCollection();
    }
}

