using System;

namespace Models
{
    public class Distrito
    {
        public Int64 Id { get; set; }
        
        public String Nome { get; set; }
        
        public Municipio Municipio { get; set; }
    }
}