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
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
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

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
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

                string consulta = "SELECT * FROM proveedores";

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

        private void Proveedores_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private bool mensajeMostrado = false;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string textoBusqueda = textBox1.Text.ToLower(); // Obtener el texto de búsqueda



            foreach (DataGridViewRow row in dataGridView1.Rows) // Recorrer todas las filas
            {



                string codigo = row.Cells["ID_Proveedores"].Value != null ? row.Cells["ID_Proveedores"].Value.ToString().ToLower() : "";
                string nombreCompleto = row.Cells["Nombre_Proveedor"].Value != null ? row.Cells["Nombre_Proveedor"].Value.ToString().ToLower() : "";



                if (codigo.IndexOf(textoBusqueda) == 0 || nombreCompleto.IndexOf(textoBusqueda) >= 0) // Buscar la coincidencia con el código o el nombre
                {
                    row.Selected = true; // Seleccionar la fila que contiene el código o el nombre
                    dataGridView1.FirstDisplayedScrollingRowIndex = row.Index; // Desplazarse hacia la fila seleccionada
                }
                else
                {
                    row.Selected = false; // Deseleccionar la fila que no cumple con la búsqueda
                }




            }
            if (dataGridView1.SelectedRows.Count == 0 && !string.IsNullOrEmpty(textoBusqueda)) // Si no se encontraron coincidencias y hay una búsqueda en curso
            {
                if (!mensajeMostrado)
                {
                    MessageBox.Show("No se encontraron registros que coincidan con la búsqueda.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mensajeMostrado = true;
                }
                else
                {
                    mensajeMostrado = false;
                }
            }
        }
    }
}
