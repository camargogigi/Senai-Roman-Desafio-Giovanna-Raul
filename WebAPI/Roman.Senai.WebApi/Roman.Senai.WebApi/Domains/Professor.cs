using System;
using System.Collections.Generic;

namespace Roman.Senai.WebApi.Domains
{
    public partial class Professor
    {
        public int IdProf { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
