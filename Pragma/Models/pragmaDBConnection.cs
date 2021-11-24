using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Pragma.Models
{
    public class pragmaDBConnection : DbContext
    {
        public pragmaDBConnection () : base("pragmaDBConnection")
        {

        }

        public DbSet<InventariosModel> Inventario { get; set; }

        public DbSet<Venta> Ventas { get; set; }

        public DbSet<loteProductoModel> loteProductoModels { get; set; }

        public System.Data.Entity.DbSet<Pragma.Models.Usuario> Usuarios { get; set; }
    }
}