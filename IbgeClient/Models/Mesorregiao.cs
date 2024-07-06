using System;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace IbgeClient.Models
{
    public class Mesorregiao
    {
        public Int64 Id { get; set; }
    
        public String Nome { get; set; }
    
        [JsonProperty("UF")]
        [JsonPropertyName("UF")]
        public Estado Estado { get; set; }
    }
}