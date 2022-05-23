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

        public int Codigo { get; set; }
        public string Direccion { get; set; }
        public string destinatario { get; set; }
        public string ubicacion { get; set; }
        public string Estado { get; set; }
        public string Observacion { get; set; }
    }
}
