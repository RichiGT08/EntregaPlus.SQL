using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntregaPlus.Models
{
    [Table ("Paquetes")]
   public class Entrega
    {
        [PrimaryKey]

        public int codigo { get; set; }
        public string direccion { get; set; }
        public string destinatario { get; set; }
        public string ubicacion { get; set; }
        public string estado { get; set; }
        public string observacion { get; set; }
    }
}
