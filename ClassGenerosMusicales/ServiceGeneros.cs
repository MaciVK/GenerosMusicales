using ClassGenerosMusicales.Models;
using ClassGenerosMusicales.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGenerosMusicales
{
    public class ServiceGeneros : IServiceGeneros
    {
        RepositoryGeneros repo;
        public ServiceGeneros()
        {
            this.repo = new RepositoryGeneros();
        }
        public List<Autor> GetAutores()
        {
            return this.repo.GetAutores();
        }

        public List<Autor> GetAutoresGenero(int idgenero)
        {
            return this.repo.GetAutoresGenero(idgenero);
        }

        public List<Genero> GetGeneros()
        {
            return this.repo.GetGeneros();
        }
    }
}
