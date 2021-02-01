using System;

namespace IbgeClient.Models
{
    public class Distrito
    {
        public Int64 Id { get; set; }
        
        public String Nome { get; set; }
        
        public Municipio Municipio { get; set; }
    }
}