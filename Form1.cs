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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
     

        //al momento de ejecutar, abrir el form inicio
        private void Login_Load(object sender, EventArgs e)
        {
            btnIniciarsesion.BackColor = Color.Coral;
            abrirForm(null, e);
        }

        //mandar a llamar el form al panel
        private void abrirForm(object sender, EventArgs e)
        {
            AbrirForm(new Inicio());
        }



        //codigo para poder arrastrar la ventana por la pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd,int wmsg,int wparam, int lparam);
        //codigo para poder arrastrar la ventana por la pantalla



            //mostramos lso form en el panel "Panel General"
            public void AbrirForm(Object fromHijo) { 
            if (this.PanelGeneral.Controls.Count > 0) 
                this.PanelGeneral.Controls.RemoveAt(0);
            Form fh = fromHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelGeneral.Controls.Add(fh);
            this.PanelGeneral.Tag = fh;
            fh.Show();
            
        }

       

        //Permite que el raton arrastre la ventana por la pantalla
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
       
        //cerrar app
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //minimizar app
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirForm(new Inicio());
            btnRegistrar.BackColor = Color.Transparent;
            btnIniciarsesion.ForeColor = Color.White;
            btnRegistrar.ForeColor = Color.Black;
            btnIniciarsesion.BackColor = Color.Coral;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            AbrirForm(new Registro());
            btnIniciarsesion.BackColor = Color.Transparent;
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.BackColor = Color.Coral;
            btnIniciarsesion.ForeColor = Color.Black;
        }
    }
}
