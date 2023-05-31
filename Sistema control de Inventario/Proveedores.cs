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

        private void button1_Click(object sender, EventArgs e)
        {
            //boton eliminar
            string servidor = "127.0.0.1";
            string puerto = "3306";
            string inventario = "root";
            string clave = "";

            if (dataGridView1.SelectedCells.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                int id = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["ID_Proveedores"].Value);

                if (MessageBox.Show("¿Estás seguro de eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        string connectionString = "server =" + servidor + ";port=" + puerto + ";user id=" + inventario + ";password=" + clave + ";database=inventario";
                        using (MySqlConnection connection = new MySqlConnection(connectionString))
                        {
                            connection.Open();

                            string consulta = "DELETE FROM proveedores WHERE ID_Proveedores = @id";
                            using (MySqlCommand command = new MySqlCommand(consulta, connection))
                            {
                                command.Parameters.AddWithValue("@id", id);
                                command.ExecuteNonQuery();
                            }

                            MessageBox.Show("Registro eliminado correctamente.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarDatos();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void CargarDatos()
        {
            //Esto para que cada vez que hagamos alguna acción se actualize en tiempo real la tabla
            string servidor = "127.0.0.1";
            string puerto = "3306";
            string inventario = "root";
            string clave = "";

            try
            {
                string connectionString = "server =" + servidor + ";port=" + puerto + ";user id=" + inventario + ";password=" + clave + ";database=inventario";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string consulta = "SELECT * FROM proveedores";
                    using (MySqlCommand command = new MySqlCommand(consulta, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //boton agregar

            string servidor = "127.0.0.1";
            string puerto = "3306";
            string inventario = "root";
            string clave = "";


            string Id = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el id del proveedor:", "Agregar dato");
            string Nombre = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre del proveedor:", "Agregar dato");
            string Rut = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el rut del proveedor:", "Agregar dato");
            string Direccion = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la dirección del proveedor:", "Agregar dato");
            string Correo = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el correo del proveedor:", "Agregar dato");
            string Telefono = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el telefono del proveedor:", "Agregar dato");

            if (!string.IsNullOrEmpty(Id) && !string.IsNullOrEmpty(Nombre) && !string.IsNullOrEmpty(Rut) && !string.IsNullOrEmpty(Direccion) && !string.IsNullOrEmpty(Correo) && !string.IsNullOrEmpty(Telefono))
            {
                try
                {
                    string connectionString = "server =" + servidor + ";port=" + puerto + ";user id=" + inventario + ";password=" + clave + ";database=inventario";
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        string consulta = "INSERT INTO proveedores (ID_Proveedores, Nombre_Proveedor, Rut_Proveedor, Direccion_Proveedor, Correo_Proveedor, Telefono_Proveedor) VALUES (@id, @nombre, @rut, @direccion, @correo, @telefono)";

                        MySqlCommand command = new MySqlCommand(consulta, connection);
                        command.Parameters.AddWithValue("@id", Id);
                        command.Parameters.AddWithValue("@nombre", Nombre);
                        command.Parameters.AddWithValue("@rut", Rut);
                        command.Parameters.AddWithValue("@direccion", Direccion);
                        command.Parameters.AddWithValue("@correo", Correo);
                        command.Parameters.AddWithValue("@telefono", Telefono);
                        command.ExecuteNonQuery();

                        Id = "";
                        Nombre = "";
                        Rut = "";
                        Direccion = "";
                        Correo = "";
                        Telefono = "";

                        CargarDatos();
                        MessageBox.Show("Datos agregados correctamente.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar los datos: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }

        }
    }
}