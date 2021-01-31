using System;
using Newtonsoft.Json;

namespace Models
{
    public class Mesorregiao
    {
        public Int64 Id { get; set; }
    
        public String Nome { get; set; }
    
        [JsonProperty("UF")]
        public Estado Estado { get; set; }
    }
}