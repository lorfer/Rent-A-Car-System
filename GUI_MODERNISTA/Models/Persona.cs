﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GUI_MODERNISTA.Models
{
    class Persona
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        [StringLength(100), Required]
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public DateTime Edad { get; set; }
        public string direccion { get; set; }
    }
}
