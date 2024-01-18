using Newtonsoft.Json;

namespace RainfallApi.Services.Model;
public class ItemsReadingsCollection
{
    [JsonProperty("@id")]
    public string? Id { get; set; }
    [JsonProperty("dateTime")]
    public string? DateTime { get; set; }
    [JsonProperty("measure")]
    public string? Measure { get; set; }
    [JsonProperty("value")]
    public string? Value { get; set; }
}