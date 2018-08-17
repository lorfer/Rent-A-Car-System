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
    public class Cliente : DatosBasicos
    {
        [Key]
        public int IdCliente { get; set; }
        [StringLength(15), Required]
        public string TipoDocumento { get; set; }
        [StringLength(13), Required]
        public string NumDocumento { get; set; }

        public void InsertarCliente(string _Nombre, string _Apellido, int _Edad, string _TipoDocumento, string _NumDocumento,
                                    string _Telefono, string _Direccion, string _Email)
        {
            using (DataB db = new DataB())
            {
                var c = new Cliente()
                {
                    Nombre = _Nombre,
                    Apellido = _Apellido,
                    Edad = _Edad,
                    TipoDocumento = _TipoDocumento,
                    NumDocumento = _NumDocumento,
                    Telefono = _Telefono,
                    Direccion = _Direccion,
                    Email = _Email,
                };

                db.Clientes.Add(c);

                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Cliente Insertado");
                }
                catch (DbEntityValidationException es)
                {
                    MessageBox.Show("" + es.Message);

                }
            }
        }

        public List<Cliente> CargarGridCliente()
        {
            using (DataB db = new DataB())
            {
                return db.Clientes.ToList();
            }
        }
    }
}
