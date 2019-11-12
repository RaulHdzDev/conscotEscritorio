using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace ConscotEscritorio
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }
        //codigo para poder arrastrar la ventana por la pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //codigo para poder arrastrar la ventana por la pantalla


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }



        //boton cerrar
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //boton minimizar
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        //Permite que el raton arrastre la ventana por la pantalla
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }



        private void txtUsuarioR_Enter_1(object sender, EventArgs e)
        {

        }



        //nombre
        private void txtNombreR_Enter(object sender, EventArgs e)
        {
            if (txtNombreR.Text == "Nombre")
            {
                txtNombreR.Text = "";
            }
        }
        private void txtNombreR_Leave(object sender, EventArgs e)
        {
            if (txtNombreR.Text == "")
            {
                txtNombreR.Text = "Nombre";

            }
        }

        private void txtUsuarioR_Enter(object sender, EventArgs e)
        {
            if (txtUsuarioR.Text == "Usuario")
            {
                txtUsuarioR.Text = "";
            }
        }

        private void txtUsuarioR_Leave(object sender, EventArgs e)
        {
            if (txtUsuarioR.Text == "")
            {
                txtUsuarioR.Text = "Usuario";

            }
        }

        private void txtContraseñaR_Enter(object sender, EventArgs e)
        {
           if (txtContraseñaR.Text == "Contraseña")
            {
                txtContraseñaR.Text = "";
                txtContraseñaR.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseñaR_Leave(object sender, EventArgs e)
        {
            if (txtContraseñaR.Text == "")
            {
                txtContraseñaR.Text = "Contraseña";
                txtContraseñaR.UseSystemPasswordChar = false;
            }
        }

        private void txtConfirmarR_Enter(object sender, EventArgs e)
        {
            if (txtConfirmarR.Text == "Confirmar contraseña")
            {
                txtConfirmarR.Text = "";
                txtConfirmarR.UseSystemPasswordChar = true;
            }
        }

        private void txtConfirmarR_Leave(object sender, EventArgs e)
        {
            if (txtConfirmarR.Text == "")
            {
                txtConfirmarR.Text = "Confirmar contraseña";
                txtConfirmarR.UseSystemPasswordChar = false;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
           
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void textCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "Correo")
            {
                txtCorreo.Text = "";
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                txtCorreo.Text = "Correo";
            }
        }
    }
}
