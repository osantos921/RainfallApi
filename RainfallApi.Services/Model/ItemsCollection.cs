using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainfallApi.Services.Model;

public class ItemsCollection
{
    [JsonProperty("@id")]
    public string? Id { get; set; }
    [JsonProperty("easting")]
    public string? Easting { get; set; }
    [JsonProperty("gridReference")]
    public string? GridReference { get; set; }
    [JsonProperty("label")]
    public string? Label { get; set; }
    [JsonProperty("lat")]
    public string? Lat { get; set; }
    [JsonProperty("long")]
    public string? Long { get; set; }
    [JsonProperty("measures")]
    public List<MeasuresCollection>? Measures { get; set; }
    [JsonProperty("northing")]
    public string? Northing { get; set; }
    [JsonProperty("notation")]
    public string? Notation { get; set; }
    [JsonProperty("stationReference")]
    public string? StationReference { get; set; }
}
