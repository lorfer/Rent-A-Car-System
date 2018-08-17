using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Validation;
using System.Windows.Forms;

namespace GUI_MODERNISTA.Models
{
    public class Usuario : DatosBasicos
    {
        [Key]
        public int IdUsuario { get; set; }
        [StringLength(13), Required]
        public string Cedula { get; set; }
        [StringLength(20), Required]
        public string Cuenta { get; set; }
        [StringLength(15), Required]
        public string TipoCuenta { get; set; }
        [StringLength(16), Required]
        public string Password { get; set; }

        public void InsertarUsuario(string _Nombre, string _Apellido, int _Edad, string _Cedula, string _Telefono,
                                    string _Direccion, string _Email, string _Cuenta, string _TipoCuenta, string _Password)
        {
            using (DataB db = new DataB())
            {
                var u = new Usuario()
                {
                    Nombre = _Nombre,
                    Apellido = _Apellido,
                    Edad = _Edad,
                    Cedula = _Cedula,
                    Telefono = _Telefono,
                    Direccion = _Direccion,
                    Email = _Email,
                    Cuenta = _Cuenta,
                    TipoCuenta = _TipoCuenta,
                    Password = _Password
                };

                db.Usuarios.Add(u);

                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Usuario Insertado");
                }
                catch (DbEntityValidationException es)
                {
                    MessageBox.Show("" + es.Message);

                }

            }
        }

        public List<Usuario> CargarGridUsuario()
        {
            using (DataB db = new DataB())
            {
                return db.Usuarios.ToList();
            }
        }

    }
}
