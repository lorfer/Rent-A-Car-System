using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_MODERNISTA.Models
{
    class ContextoDB : DbContext
    {
        public ContextoDB() : base("Data Source=HP-PC;Initial Catalog=Agenda;Integrated Security=True") { }
        public DbSet<Usuarios> usuarios { get; set; }
        public DbSet<Persona> Personas { get; set; }
    }
}
