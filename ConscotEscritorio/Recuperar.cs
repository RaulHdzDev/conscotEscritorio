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
    public partial class Recuperar : Form
    {
        public Recuperar()
        {
            InitializeComponent();
        }


        //codigo para poder arrastrar la ventana por la pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //codigo para poder arrastrar la ventana por la pantalla



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnIniciarsesion_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnIniciarsesion_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
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

        private void Recuperar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
