using Roman.Senai.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roman.Senai.WebApi.Repositories
{
    public class ProjetoRepository
    {
        //listar
        public List<Projeto> Listar()
        {
            using (RomanContext ctx = new RomanContext())
            {
                return ctx.Projeto.ToList();
            }
        }//fim listar

        //cadastrar
        public void Cadastrar(Projeto projeto)
        {
            using (RomanContext ctx = new RomanContext())
            {
                //insert into
                ctx.Projeto.Add(projeto);
                ctx.SaveChanges();
            }
        }//fim cadastrar
    }
}
