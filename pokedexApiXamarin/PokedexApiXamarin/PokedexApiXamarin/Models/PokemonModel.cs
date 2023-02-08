using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokedexApiXamarin.Models
{
    // internal class PokemonModel
    public class PokemonModel
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
    }
}
