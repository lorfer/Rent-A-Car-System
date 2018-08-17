using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_MODERNISTA.Models
{
    class DataB : DbContext
    {
        //El string de conexion esta en App.config debajo de </entityFramework
        public DataB() : base("name=DBRentCar") { } 

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }
    }
}
