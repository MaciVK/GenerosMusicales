using ClassGenerosMusicales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClassGenerosMusicales
{
    [ServiceContract]
    public interface IServiceGeneros
    {
        [OperationContract]
        List<Genero> GetGeneros();
        [OperationContract]
        List<Autor> GetAutores();
        [OperationContract]
        List<Autor> GetAutoresGenero(int idgenero);

    }
}
