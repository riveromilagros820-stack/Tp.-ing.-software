using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp_ing.software.Rivero___D_argenzio
{
    public partial class fmrRegistro : Form
    {
        public fmrRegistro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string apellido = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();
            string confirmar = txtConfirmContraseña.Text.Trim();

            // Validaciones básicas en UI
            if (string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(contraseña) || string.IsNullOrEmpty(confirmar))
            {
                MessageBox.Show("Debe completar todos los campos.");
                return;
            }

            if (contraseña != confirmar)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }

           
            int dni;
            if (!int.TryParse(txtContraseña.Text, out dni))   
            {
                MessageBox.Show("El DNI debe ser numérico.");
                return;
            }

            Usuario nuevoUsuario = new Usuario
            {
                Apellido = apellido,
                DNI = dni,                        
                Contraseña = dni.ToString(),     
                IdiomaId = 1,
                Activo = true
            };

            // Llamar a la capa de negocio
            BLLUsuario bllUsuario = new BLLUsuario ();
            bool creado = bllUsuario.CrearUsuario(nuevoUsuario);

            if (creado)
            {
                MessageBox.Show("Cuenta creada. Debe cambiar su contraseña.");
                frmCambioContraseña cambio = new frmCambioContraseña(nuevoUsuario);
                cambio.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("El usuario ya existe o hubo un error.");
            }




        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            fmrLogin login = new fmrLogin ();
            login.Show();
            this.Hide();
        }
    }
}
