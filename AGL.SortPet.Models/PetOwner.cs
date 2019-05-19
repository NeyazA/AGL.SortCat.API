using Newtonsoft.Json;
using System.Collections.Generic;

namespace AGL.SortPet.Models
{
    public class PetOwner
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
        [JsonProperty("gender")]
        public string Gender { get; set; }
        [JsonProperty("age")]
        public int Age { get; set; }
        [JsonProperty("pets", NullValueHandling = NullValueHandling.Ignore)]
        public List<Pet>Pets { get; set; }
    }
}
