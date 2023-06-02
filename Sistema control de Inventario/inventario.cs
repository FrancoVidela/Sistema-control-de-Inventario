using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sistema_control_de_Inventario
{
    public partial class inventario : Form
    {
        public inventario()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void stockDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inventario_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }



        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar sesion?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Sesion cerrada");
                Login log = new Login();
                this.Hide();
                log.Show();


            }
            else
            {
                MessageBox.Show("Error");
            }



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MostrarDatos()

        {
            string servidor = "127.0.0.1";
            string puerto = "3306";
            string inventario = "root";
            string clave = "";
            string usuario;
            string pass;


            string connectionString = "server =" + servidor + ";port=" + puerto + ";user id=" + inventario + ";password=" + clave + ";database=inventario";

            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                string consulta = "SELECT * FROM productos";

                MySqlCommand command = new MySqlCommand(consulta, connection);
                MySqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView1.DataSource = dataTable;
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string servidor = "127.0.0.1";
            string puerto = "3306";
            string inventario = "root";
            string clave = "";
            string usuario;
            string pass;

            string connectionString = "server =" + servidor + ";port=" + puerto + ";user id=" + inventario + ";password=" + clave + ";database=inventario";
            MySqlConnection connection = new MySqlConnection(connectionString);

            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                conexion.Open();

                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    string idProducto = fila.Cells["ID_Producto"].Value.ToString();
                    string nombreProducto = fila.Cells["Nombre_Producto"].Value.ToString();
                    string cantidadProducto = fila.Cells["Cantidad_Producto"].Value.ToString();

                    // Ejecutar la actualización en la base de datos
                    string consulta = "UPDATE productos SET Nombre_Producto = @nombre, Cantidad_Producto = @cantidad WHERE ID_Producto = @id";
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@nombre", nombreProducto);
                        comando.Parameters.AddWithValue("@cantidad", cantidadProducto);
                        comando.Parameters.AddWithValue("@id", idProducto);
                        comando.ExecuteNonQuery();
                    }
                }

                
                MostrarDatos();

                conexion.Close();

                MessageBox.Show("Los registros se han actualizado correctamente.","Actualización Existosa",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }

        private void inventario_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
