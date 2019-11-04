using System;
using System.Collections.Generic;

namespace Roman.Senai.WebApi.Domains
{
    public partial class Projeto
    {
        public int IdProjeto { get; set; }
        public string Nome { get; set; }
        public int? IdTema { get; set; }

        public Tema IdTemaNavigation { get; set; }
    }
}
