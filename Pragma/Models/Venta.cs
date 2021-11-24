using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Pragma.Models
{
    [Table("venta")]
    public class Venta
    {
        [Key]
        public int id_venta { get; set; }
        public int id_loteProducto { get; set; }
        public string nombre_producto { get; set; }
        public int cantidad_producto { get; set; }
        public decimal precio { get; set; }
        public decimal descuento { get; set; }
        public int id_usuario { get; set; }

    }
}