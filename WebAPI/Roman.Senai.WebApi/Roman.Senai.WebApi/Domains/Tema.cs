using System;
using System.Collections.Generic;

namespace Roman.Senai.WebApi.Domains
{
    public partial class Tema
    {
        public Tema()
        {
            Projeto = new HashSet<Projeto>();
        }

        public int IdTema { get; set; }
        public string Tema1 { get; set; }

        public ICollection<Projeto> Projeto { get; set; }
    }
}
