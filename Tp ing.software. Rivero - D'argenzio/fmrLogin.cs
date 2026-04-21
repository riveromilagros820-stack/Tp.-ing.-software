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


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



       /* private void btnIngresar_Click(object sender, EventArgs e)
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



        } */

        private void fmrLogin_Load(object sender, EventArgs e)
        {

        }

        /*private void InitializeComponent()
        {
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.txtConfirmContraseña = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.cbMostrarContraseña = new System.Windows.Forms.CheckBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.Location = new System.Drawing.Point(96, 386);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(158, 30);
            this.btnIniciarSesion.TabIndex = 31;
            this.btnIniciarSesion.Text = "Iniciar Sesion";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            // 
            // txtConfirmContraseña
            // 
            this.txtConfirmContraseña.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtConfirmContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmContraseña.Location = new System.Drawing.Point(74, 224);
            this.txtConfirmContraseña.Multiline = true;
            this.txtConfirmContraseña.Name = "txtConfirmContraseña";
            this.txtConfirmContraseña.Size = new System.Drawing.Size(216, 28);
            this.txtConfirmContraseña.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Confirmar contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Ya tengo cuenta";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(64, 291);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(216, 35);
            this.btnRegistrar.TabIndex = 27;
            this.btnRegistrar.Text = "REGISTRARME";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // cbShowPassword
            // 
            this.cbMostrarContraseña.AutoSize = true;
            this.cbMostrarContraseña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbMostrarContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMostrarContraseña.Location = new System.Drawing.Point(140, 258);
            this.cbMostrarContraseña.Name = "cbShowPassword";
            this.cbMostrarContraseña.Size = new System.Drawing.Size(114, 17);
            this.cbMostrarContraseña.TabIndex = 26;
            this.cbMostrarContraseña.Text = "Mostrar contraseña";
            this.cbMostrarContraseña.UseVisualStyleBackColor = true;
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.Location = new System.Drawing.Point(74, 150);
            this.txtContraseña.Multiline = true;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(216, 28);
            this.txtContraseña.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Location = new System.Drawing.Point(74, 78);
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(216, 28);
            this.txtUsuario.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Location = new System.Drawing.Point(133, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "INICIAR SESIÓN";
            // 
            // fmrLogin
            // 
            this.ClientSize = new System.Drawing.Size(354, 434);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.txtConfirmContraseña);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cbMostrarContraseña);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fmrLogin";
            this.Load += new System.EventHandler(this.fmrLogin_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        } */

        private void fmrLogin_Load_1(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
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

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            // Instanciamos el formulario de registro
            fmrRegistro formularioRegistro = new fmrRegistro();

            // Mostramos el formulario de registro
            formularioRegistro.Show();

            // Opcional: Ocultamos el formulario de login actual
            this.Hide();
        }
    }





        
}
