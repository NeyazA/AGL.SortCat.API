using Newtonsoft.Json;

namespace AGL.SortCat.Models
{
    public class Pet
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
