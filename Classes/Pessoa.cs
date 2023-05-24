using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodificacaoAT.Classes
{
    public abstract class Pessoa
    {
        public string? Nome {get; set;}

        public float Rendimento { get; set; }
    }
}