using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GUI_MODERNISTA.Models
{
    class Usuarios:Persona
    {
        [Key]
        public int IdUsuario { get; set; }
        public string  NombreUsuario { get; set; }
        [StringLength (30), Required]
        public string Contraseña { get; set; }
        [StringLength (20), Required]
        public string  Rol { get; set; }
        
    }
}
