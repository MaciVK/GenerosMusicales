using ClassGenerosMusicales.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGenerosMusicales.Data
{
    public class GenerosContext:DbContext
    {
        public GenerosContext() : base("name=cadenageneros") { }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Autor> Autores { get; set; }
    }
}
