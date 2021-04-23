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
    [Table("AUTOR")]
    public class Autor
    {
        [Key]
        [Column("IDAUTOR")]
        [DataMember]
        public int IdAutor { get; set; }
        [Column("NOMBRE")]
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        [Column("IDGENERO")]
        public int IdGenero { get; set; }
    }
}
