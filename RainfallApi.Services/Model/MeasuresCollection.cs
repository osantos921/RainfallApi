using Newtonsoft.Json;

namespace RainfallApi.Services.Model
{
    public class MeasuresCollection
    {

        [JsonProperty("@id")]
        public string? Id { get; set; }
        [JsonProperty("parameter")]
        public string? Parameter { get; set; }
        [JsonProperty("parameterName")]
        public string? ParameterName { get; set; }
        [JsonProperty("period")]
        public string? Period { get; set;}
        [JsonProperty("qualifier")]
        public string? Qualifier { get; set;}
        [JsonProperty("unitName")]
        public string? UnitName { get; set; }
    }
}
