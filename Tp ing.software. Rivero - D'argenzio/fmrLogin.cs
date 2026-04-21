using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp_ing.software.Rivero___D_argenzio
{
    public partial class fmrLogin : Form
    {
        public fmrLogin()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string apellido = txtUsuario.Text.Trim();
            string pass = txtContraseña.Text.Trim();

            int dni;
            if (!int.TryParse(pass, out dni))
            {
                MessageBox.Show("La contraseña debe ser numérica (DNI).");
                return;
            }

        
            Usuario u = BLLLogin.Instancia.ValidarLogin(apellido, dni, pass);

            if (u != null)
            {
                MessageBox.Show("Login correcto. Debe cambiar su contraseña.");
                frmCambioContraseña cambio = new frmCambioContraseña(u);
                cambio.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }



        }

        private void fmrLogin_Load(object sender, EventArgs e)
        {

        }
    }





        
}
