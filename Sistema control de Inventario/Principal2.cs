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

namespace Sistema_control_de_Inventario
{
    public partial class Principal2 : Form
    {
        public Principal2()
        {
            InitializeComponent();
            panelInformes.Visible= false;
        }

        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar sesion?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Sesion cerrada");
                Login log = new Login();
                this.Hide();
                log.Show();


            }

        }


        private void AbrirForm(object Formhijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();

        }
        private void btnProductos_Click(object sender, EventArgs e)
        {
            panelInformes.Visible = false;

            inventario2 inv = new inventario2();
            inv.FormClosed += new FormClosedEventHandler(MostraralcerrarForm);
            AbrirForm(inv);
            
        }


        private void btnMen_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 63;

            }
            else
            {
                MenuVertical.Width = 250;

            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Seguro de cerrar?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {

                Application.Exit();

            }


        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        int LX;
        int LY;
        private void Maximizar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            LX = this.Location.X; LY = this.Location.Y;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            Restaurar.Visible = true;
            Maximizar.Visible = false;
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            this.Size = new Size(1300, 650);
            this.Location = new Point(LX, LY);
            Restaurar.Visible = false;
            Maximizar.Visible = true;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            MostrarLogo();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            //  AbrirForm(new Inicio());
        }

        private void MostrarLogo()
        {
            AbrirForm(new Inicio2());
        }

        private void MostraralcerrarForm(object sender, FormClosedEventArgs e)
        {
            MostrarLogo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelInformes.Visible = false;
            Proveedor2 pr = new Proveedor2();
            pr.FormClosed += new FormClosedEventHandler(MostraralcerrarForm);
            AbrirForm(pr);
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            panelInformes.Visible = !panelInformes.Visible;
            
        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
