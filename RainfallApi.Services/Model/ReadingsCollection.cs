using Newtonsoft.Json;

namespace RainfallApi.Services.Model;
    public class ReadingsCollection
    {
        [JsonProperty("@context")]
        public string? Context { get; set; }

        [JsonProperty("meta")]
        public MetaCollection? Meta { get; set; }

        [JsonProperty("items")]
        public List<ItemsReadingsCollection>? Items { get; set; }

    }

