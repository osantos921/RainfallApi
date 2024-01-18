using Newtonsoft.Json;

namespace RainfallApi.Services.Model;
public class MetaCollection
{
    [JsonProperty("publisher")]
    public string? Publisher { get; set; }

    [JsonProperty("licence")]
    public string? License { get; set;}

    [JsonProperty("documentation")]
    public string? Documentation { get; set; }

    [JsonProperty("version")]
    public string? Version { get; set; }

    [JsonProperty("comment")]
    public string? Comment { get; set; }

    [JsonProperty("hasFormat")]
    public string[]? HasFormat { get; set; }

}