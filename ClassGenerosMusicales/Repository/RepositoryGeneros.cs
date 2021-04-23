using ClassGenerosMusicales.Data;
using ClassGenerosMusicales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGenerosMusicales.Repository
{
    public class RepositoryGeneros
    {
        GenerosContext context;
        public RepositoryGeneros()
        {
            this.context = new GenerosContext();
        }
        public List<Genero> GetGeneros()
        {
            return this.context.Generos.ToList();
        }
        public List<Autor> GetAutores()
        {
            return this.context.Autores.ToList();
        }
        public List<Autor> GetAutoresGenero(int idgenero)
        {
            return this.context.Autores.Where(x => x.IdGenero == idgenero).ToList();
        }
    }
}
