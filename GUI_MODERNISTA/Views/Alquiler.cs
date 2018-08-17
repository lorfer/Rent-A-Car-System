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
	public partial class Alquiler : Form
	{

		int fila, costo;
        TimeSpan Time;

		public Alquiler()
		{
			InitializeComponent();
			
			
		}

		private void cbDocumento_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void label9_Click(object sender, EventArgs e)
		{

		}

		private void txtApellido_TextChanged(object sender, EventArgs e)
		{

		}

		private void Alquiler_Load(object sender, EventArgs e)
		{
			Cliente costumer = new Cliente();
			gridCliente.DataSource = costumer.CargarGridCliente();

            Vehiculo cars = new Vehiculo();
            gridVehiculo.DataSource = cars.CargarGridVehiculo();
        }

		private void btnBuscarCliente_Click(object sender, EventArgs e)
		{
				
		}

		private void gridCliente_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			//txtNombre.Text = gridCliente[3, 0].Value.ToString();
		}

		private void gridCliente_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			fila = gridCliente.CurrentRow.Index;
			txtNombre.Text = gridCliente[3, fila].Value.ToString();
			txtDocumento.Text = gridCliente[2, fila].Value.ToString();
			txtTelefono.Text = gridCliente[6, fila].Value.ToString();
		}
        
		public List<Cliente> CargarGridCliente()
		{
			using (DataB db = new DataB())
			{
				return db.Clientes.ToList();
			}
		}

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void gridVehiculo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = gridVehiculo.CurrentRow.Index;
            gridAlquiler[0, gridAlquiler.RowCount - 1].Value = gridVehiculo[0, fila].Value.ToString();
            gridAlquiler[1, gridAlquiler.RowCount - 1].Value = gridVehiculo[1, fila].Value.ToString();
            gridAlquiler[2, gridAlquiler.RowCount - 1].Value = gridVehiculo[2, fila].Value.ToString();
            gridAlquiler[3, gridAlquiler.RowCount - 1].Value = gridVehiculo[3, fila].Value.ToString();
            gridAlquiler[4, gridAlquiler.RowCount - 1].Value = gridVehiculo[7, fila].Value.ToString();
            gridAlquiler[5, gridAlquiler.RowCount - 1].Value = gridVehiculo[8, fila].Value.ToString();
            gridAlquiler[6, gridAlquiler.RowCount - 1].Value = 1;
        }

        public void CalcularTiempo(DateTime Inicio, DateTime Fin)
        {
            Time = Inicio.Subtract(Fin);
        }

        public int CostoAlquiler(int AlVehiculo)
        {
            costo = AlVehiculo * Convert.ToInt32(Math.Abs(Time.Days));

            return costo;
        }

        private void dateFechaF_ValueChanged(object sender, EventArgs e)
        {
            DateTime inicio = Convert.ToDateTime(dateFechaI.Value);
            DateTime fin = Convert.ToDateTime(dateFechaF.Value);
            CalcularTiempo(inicio, fin);
            lbTotal.Text = (CostoAlquiler(Convert.ToInt32(gridAlquiler[4, 0].Value))).ToString();
            CalcularMora(Convert.ToDateTime(dateFechaF.Value));
        }

        public void CalcularMora(DateTime Limite)
        {
            var Actual = DateTime.Now;

            if (Limite > Actual)
            {
                double mora = costo * 0.5;
                double total = costo + mora;
            }
        }
    }
}
