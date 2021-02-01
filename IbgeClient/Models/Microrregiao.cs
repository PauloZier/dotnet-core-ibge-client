using System;

namespace IbgeClient.Models
{
    public class Microrregiao
    {
        public Int64 Id { get; set; }

        public String Nome { get; set; }

        public Mesorregiao Mesorregiao { get; set; }
    }
}