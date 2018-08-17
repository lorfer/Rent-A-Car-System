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

namespace GUI_MODERNISTA.Views
{
    public partial class RegistrarVehiculo : Form
    {
        public RegistrarVehiculo()
        {
            InitializeComponent();
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipo.Text == "Carros")
            {
                cbMarca.Items.Clear();
                cbMarca.Items.Add("Kia");
                cbMarca.Items.Add("Hyundai");
                cbMarca.Items.Add("Audi");
            }
            else if (cbTipo.Text == "SUV")
            {
                cbMarca.Items.Clear();
                cbMarca.Items.Add("Suzuki");
                cbMarca.Items.Add("Hyundai");
                cbMarca.Items.Add("Kia");;
            }
            else if(cbTipo.Text == "Camionetas")
            {
                cbMarca.Items.Clear();
                cbMarca.Items.Add("Mazda");
                cbMarca.Items.Add("Nissan");
                cbMarca.Items.Add("Toyota");
            }
        }

        private void RegistrarVehiculo_Load(object sender, EventArgs e)
        {
            cbTipo.Items.Add("Carros");
            cbTipo.Items.Add("SUV");
            cbTipo.Items.Add("Camionetas");

            Vehiculo ve = new Vehiculo();
            gridVehiculo.DataSource = ve.CargarGridVehiculo();
        }

        private void cbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            //CARROS
            if (cbTipo.Text == "Carros" && cbMarca.Text == "Kia")
            {
                cbModelo.Items.Clear();
                cbModelo.Items.Add("Picanto");
                cbModelo.Items.Add("Rio");
            }
            else if (cbTipo.Text == "Carros" && cbMarca.Text == "Hyundai")
            {
                cbModelo.Items.Clear();
                cbModelo.Items.Add("Accent");
                cbModelo.Items.Add("Grand I10");
            }
            else if (cbTipo.Text == "Carros" && cbMarca.Text == "Audi")
            {
                cbModelo.Items.Clear();
                cbModelo.Items.Add("A3");
            }

            //SUV
            if (cbTipo.Text == "SUV" && cbMarca.Text == "Suzuki")
            {
                cbModelo.Items.Clear();
                cbModelo.Items.Add("Vitara");
            }
            else if (cbTipo.Text == "SUV" && cbMarca.Text == "Hyundai")
            {
                cbModelo.Items.Clear();
                cbModelo.Items.Add("Santa Fé");
                cbModelo.Items.Add("Tucson");
            }
            else if (cbTipo.Text == "SUV" && cbMarca.Text == "Kia")
            {
                cbModelo.Items.Clear();
                cbModelo.Items.Add("Sportage");
            }

            //CAMIONETAS Y VANS
            if (cbTipo.Text == "Camionetas" && cbMarca.Text == "Mazda")
            {
                cbModelo.Items.Clear();
                cbModelo.Items.Add("BT-50");                
            }            
            if (cbTipo.Text == "Camionetas" && cbMarca.Text == "Nissan")
            {
                cbModelo.Items.Clear();
                cbModelo.Items.Add("Frontier");
            }
            if (cbTipo.Text == "Camionetas" && cbMarca.Text == "Toyota")
            {
                cbModelo.Items.Clear();
                cbModelo.Items.Add("Hilux");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string tipo, marca, modelo, transmision, combustible;
            int cappasajero, stock;
            double precioalquiler;
            Vehiculo cars = new Vehiculo();

            tipo = cbTipo.Text;
            marca = cbMarca.Text;
            modelo = cbModelo.Text;
            transmision = cbTransmision.Text;
            combustible = cbCombustible.Text;
            cappasajero = Convert.ToInt32(cbPasajeros.Text);
            stock = Convert.ToInt32(txtStock.Text);
            precioalquiler = Convert.ToDouble(txtAlquiler.Text);

            cars.InsertarVehiculo(tipo, marca, modelo, cappasajero, transmision, combustible, precioalquiler, stock);

            gridVehiculo.DataSource = cars.CargarGridVehiculo();
        }
    }
}
