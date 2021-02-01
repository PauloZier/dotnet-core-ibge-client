using System;

namespace IbgeClient.Models
{
    public class Municipio
    {
        public Int64 Id { get; set; }

        public String Nome { get; set; }

        public Microrregiao Microrregiao { get; set; }
    }
}