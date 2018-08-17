using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_MODERNISTA.Models
{
    public class Vehiculo
    {
        [Key]
        public int IdVehiculo { get; set; }
        [StringLength(10), Required]
        public string Tipo { get; set; }
        [StringLength(10), Required]
        public string Marca { get; set; }
        [StringLength(10), Required]
        public string Modelo { get; set; }
        public int CapPasajero { get; set; }
        [StringLength(15), Required]
        public string Transmision { get; set; }
        [StringLength(15), Required]
        public string Combustible { get; set; }        
        public double PrecioAlquiler { get; set; }
        public int Stock { get; set; }

        public void InsertarVehiculo(string _Tipo, string _Marca, string _Modelo, int _CapPasajero, string _Transmision,
                                     string _Combustible, double _PrecioAlquiler, int _Stock)
        {
            using (DataB db = new DataB())
            {
                var v = new Vehiculo()
                {
                    Tipo = _Tipo,
                    Marca = _Marca,
                    Modelo = _Modelo,
                    CapPasajero = _CapPasajero,
                    Transmision = _Transmision,
                    Combustible = _Combustible,
                    PrecioAlquiler = _PrecioAlquiler,
                    Stock = _Stock
                };

                db.Vehiculos.Add(v);

                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Vehículo Insertado");
                }
                catch (DbEntityValidationException es)
                {
                    MessageBox.Show("" + es.Message);

                }
            }
        }

        public List<Vehiculo> CargarGridVehiculo()
        {
            using (DataB db = new DataB())
            {
                return db.Vehiculos.ToList();
            }
        }
    }
}
