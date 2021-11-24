using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Pragma.Models
{
    [Table("usuario")]
    public class Usuario
    {
        [Key]
        public int id_usuario { get; set; }
        public string tipo_usuario { get; set; }
        public string nombre_usuario { get; set; }
        public string password { get; set; }

    }
}