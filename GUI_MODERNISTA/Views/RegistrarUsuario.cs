using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI_MODERNISTA.Models;
//using GUI_MODERNISTA.Views;
using System.Data.Entity.Validation;

namespace GUI_MODERNISTA
{
    public partial class RegistrarUsuario : Form
    {
        public RegistrarUsuario()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (ContextoDB db = new ContextoDB())
            {
                var persona = new Persona() { Nombre = txtNombre.Text, Apellido = txtApellido.Text, Cedula = txtCedula.Text, direccion = txtDireccion.Text, Edad = fechaNacimiento.Value, Telefono = txtTelefono.Text };

                var usuario = new Usuarios() { NombreUsuario = txtUsuario.Text, Contraseña = txtContra.Text};


                db.usuarios.Add(usuario);
                db.Personas.Add(persona);
                    try 
	{	        
		db.SaveChanges();
	}
      catch (DbEntityValidationException es)
	{
        MessageBox.Show("" + es.Message);
        
	}
                
            }
        }
    }
}
