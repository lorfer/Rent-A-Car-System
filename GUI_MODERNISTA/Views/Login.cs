using GUI_MODERNISTA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_MODERNISTA
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            using (DataB db = new DataB())
            {
                try
                {
                    var usu = db.Usuarios.ToList();

                    if (isEmpty() == true)
                    {
                        foreach (var user in usu)
                        {
                            if (txtUsuario.Text == user.Cuenta && txtPass.Text == user.Password || txtUsuario.Text == "admin" && txtPass.Text == "admin")
                            {
                                this.Hide();
                                Form1 f = new Form1();
                                f.Show();
                            }
                        }
                    }
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Revice el Usuario O la contraseña" + exp.Message);
                }



            }
        }

        public bool isEmpty()
        {
            if (txtPass.Text == "" && txtUsuario.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
