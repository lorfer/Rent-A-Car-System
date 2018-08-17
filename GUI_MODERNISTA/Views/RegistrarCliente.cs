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

namespace GUI_MODERNISTA.Views
{
    public partial class RegistrarCliente : Form
    {
		public static string idClienteSelect;
		public int fila;

		public RegistrarCliente()
        {
            InitializeComponent();
		}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void buton1_Click(object sender, EventArgs e)
        {

        }

        private void RegistrarCliente_Load(object sender, EventArgs e)
        {
            Cliente cl = new Cliente();
            gridCliente.DataSource = cl.CargarGridCliente();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre, apellido, tipodocumento, numdocumento, telefono, direccion, email;
            int edad;
            Cliente costumer = new Cliente();

            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            edad = Convert.ToInt32(txtEdad.Text);
            tipodocumento = cbDocumento.Text;
            numdocumento = txtNDocumento.Text;
            telefono = txtTelefono.Text;
            direccion = txtDireccion.Text;
            email = txtEmail.Text;            

            costumer.InsertarCliente(nombre, apellido, edad, tipodocumento, numdocumento, telefono, direccion, email);

            gridCliente.DataSource = costumer.CargarGridCliente();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

		
		public void clienteAct()
		{
		Cliente c = new Cliente();

			c.Nombre = gridCliente[0, 3].Value.ToString();
		}

		private void gridCliente_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			

			//string nombre, documento, telefono;
			//Alquiler al = new Alquiler();

			//nombre = gridCliente[3, 0].Value.ToString();
			//documento = gridCliente[2, 0].Value.ToString();
			//telefono = gridCliente[6, 0].Value.ToString();

			//al.llenarCliente(nombre, documento, telefono);
		}

		private void gridCliente_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			
		}
	}
}
