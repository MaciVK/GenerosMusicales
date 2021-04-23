using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClassGenerosMusicales.Models
{
    [DataContract]
    [Table("GENERO")]
    public class Genero
    {
        [Key]
        [Column("IDGENERO")]
        [DataMember]
        public int IdGenero { get; set; }
        [Column("NOMBRE")]
        [DataMember]
        public string Nombre { get; set; }
    }
}
