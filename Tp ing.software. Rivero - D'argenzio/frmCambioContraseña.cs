using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp_ing.software.Rivero___D_argenzio
{
    public partial class frmCambioContraseña : Form
    {
        private Usuario usuario;

        public frmCambioContraseña(Usuario u)
        {
            InitializeComponent();
            usuario = u;
            txtUsuario.Text = usuario.Apellido + usuario.DNI; 
            txtUsuario.ReadOnly = true;
        }

        private void frmCambioContraseña_Load(object sender, EventArgs e)
        {

        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                textContraseña .UseSystemPasswordChar = false;
                txtConfirmContraseña.UseSystemPasswordChar = false;
            }
            else
            {
                textContraseña.UseSystemPasswordChar = true;
                txtConfirmContraseña.UseSystemPasswordChar = true;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string nueva = textContraseña.Text.Trim();
            string confirmar = txtConfirmContraseña.Text.Trim();

            if (string.IsNullOrEmpty(nueva) || string.IsNullOrEmpty(confirmar))
            {
                MessageBox.Show("Debe completar todos los campos.");
                return;
            }

            if (nueva != confirmar)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }

            // Llamar a la capa de negocio para cambiar contraseña
            BLLUsuario bllUsuario = new BLLUsuario();
            bool cambiado = bllUsuario.CambiarContraseña(usuario.Id, nueva);

            if (cambiado)
            {
                MessageBox.Show("Contraseña cambiada correctamente.");
                this.Close();
                // Podés abrir el menú principal aquí si querés:
                // frmMenu menu = new frmMenu();
                // menu.Show();
            }
            else
            {
                MessageBox.Show("Hubo un error al cambiar la contraseña.");
            }
        }
    }
}
