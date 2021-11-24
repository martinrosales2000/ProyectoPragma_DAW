using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Pragma.Models
{
    [Table("loteProducto")]
    public class loteProductoModel
    {
        [Key]
        public int id_loteProducto { get; set; }
        public DateTime fecha_caducidad { get; set; }
        public int stock { get; set; }
    }
}