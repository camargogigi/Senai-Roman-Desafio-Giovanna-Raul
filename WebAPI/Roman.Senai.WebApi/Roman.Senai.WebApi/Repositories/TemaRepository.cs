using Roman.Senai.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roman.Senai.WebApi.Repositories
{
    public class TemaRepository
    {
        //listar
        public List<Tema> Listar()
        {
            using (RomanContext ctx = new RomanContext())
            {
                return ctx.Tema.ToList();
            }
        }//fim listar

        //cadastrar
        public void Cadastrar(Tema tema)
        {
            using (RomanContext ctx = new RomanContext())
            {
                //insert into
                ctx.Tema.Add(tema);
                ctx.SaveChanges();
            }
        }//fim cadastrar

        //atualizar
        public void Atualizar (int id, Tema tema)
        {
            using (RomanContext ctx = new RomanContext())
            {
                Tema temas = ctx.Tema.FirstOrDefault(x => x.IdTema == id);
                temas.Nome = tema.Nome;
                ctx.Tema.Update(temas);
                ctx.SaveChanges();
            }
        }//fim atualizar
    }
}
