using System;

namespace IbgeClient.Models
{
    public class Estado
    {
        public Int64 Id { get; set; }
    
        public String Sigla { get; set; }
    
        public String Nome { get; set; }
    
        public Regiao Regiao { get; set; }
    }
}