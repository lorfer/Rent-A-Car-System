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
using GUI_MODERNISTA.Views;
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
            string nombre, apellido, cedula, telefono, direccion, email, cuenta, tipocuenta, password;
            int edad;
            Usuario user = new Usuario();

            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            edad = Convert.ToInt32(txtEdad.Text);
            cedula = txtCedula.Text;
            telefono = txtTelefono.Text;
            direccion = txtDireccion.Text;
            email = txtEmail.Text;
            cuenta = txtCuenta.Text;
            tipocuenta = txtTipoCuenta.Text;
            password = txtPassword.Text;

            user.InsertarUsuario(nombre, apellido, edad, cedula, telefono, direccion, email, cuenta, tipocuenta, password);

            gridUsuario.DataSource = user.CargarGridUsuario();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void RegistrarUsuario_Load(object sender, EventArgs e)
        {
            Usuario us = new Usuario();
            gridUsuario.DataSource = us.CargarGridUsuario();
        }
    }
}
