using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Pragma.Models
{
    [Table("inventario")]
    public class InventariosModel
    {
        [Key]
        public int id_inventario { get; set; }
        public int id_loteProducto { get; set; }
        public int cantidad_comprada { get; set; }
        public int id_usuario { get; set; }

    }
}