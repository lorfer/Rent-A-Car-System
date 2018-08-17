using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GUI_MODERNISTA.Models
{
    public class DatosBasicos
    {
        [StringLength(30), Required]
        public string Nombre { get; set; }
        [StringLength(30)]
        public string Apellido { get; set; }
        public int Edad { get; set; }
        [StringLength(12)]
        public string Telefono { get; set; }
        [StringLength(100), Required]
        public string Direccion { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
    }
}
