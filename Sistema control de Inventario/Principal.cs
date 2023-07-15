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
using MySql.Data.MySqlClient;

namespace Sistema_control_de_Inventario
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
           
        }

        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar sesion?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {

                Login log = new Login();
                this.Hide();
                MessageBox.Show("Sesion cerrada");
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
        private Button botonSeleccionado;
        private Color colorPredeterminado = Color.FromArgb(0, 122, 204);
        private Color colorSeleccionado = Color.Black;

        private void CambiarColorBotonSeleccionado(Button boton)
        {
            if (botonSeleccionado != null)
            {

                botonSeleccionado.BackColor = colorPredeterminado;
            }

            boton.BackColor = colorSeleccionado;
            botonSeleccionado = boton;
        }
        private void btnProductos_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            CambiarColorBotonSeleccionado(boton);


            

            inventario inv = new inventario();
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

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

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
            AbrirForm(new Inicio());
        }

        private void MostraralcerrarForm(object sender, FormClosedEventArgs e)
        {
            MostrarLogo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            CambiarColorBotonSeleccionado(boton);
            
            Proveedor pr = new Proveedor();
            pr.FormClosed += new FormClosedEventHandler(MostraralcerrarForm);
            AbrirForm(pr);
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {

            Button boton = (Button)sender;

            CambiarColorBotonSeleccionado(boton);
            
            string servidor = "127.0.0.1";
            string puerto = "3306";
            string inventario = "root";
            string clave = "";



            string usuario = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre de usuario:", "Agregar dato");
            string contraseña = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la contraseña del usuario:", "Agregar dato");



            if (!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(contraseña))
            {

                try
                {
                    string connectionString = "server =" + servidor + ";port=" + puerto + ";user id=" + inventario + ";password=" + clave + ";database=inventario";
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        string consulta = "INSERT INTO login (usuario, contraseña) VALUES (@usser, @cont)";

                        {

                            MySqlCommand command = new MySqlCommand(consulta, connection);
                            command.Parameters.AddWithValue("@usser", usuario);
                            command.Parameters.AddWithValue("@cont", contraseña);


                            command.ExecuteNonQuery();
                        }

                        usuario = "";
                        contraseña = "";



                        MessageBox.Show("Usuario creado exitosamente.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el usuario: " + ex.Message);
                }
                finally
                {
                    // Restablecer el color del botón al predeterminado
                    boton.BackColor = colorPredeterminado;
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                boton.BackColor = colorPredeterminado;
            }
        }

        private void MostrarBotonCrearCuenta(bool esAdministrador)
        {
            btnCrearUsuario.Visible = esAdministrador;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }




    }
}
