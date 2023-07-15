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
    public partial class Proveedor : Form
    {
        public Proveedor()
        {
            InitializeComponent();
        }



        private void inventario_Load(object sender, EventArgs e)
        {
            MostrarDatos();

        }





        private bool mensajeMostrado = false;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string textoBusqueda = textBox1.Text.ToLower(); // Obtener el texto de búsqueda

            if (string.IsNullOrEmpty(textoBusqueda))
            {
                dataGridView1.ClearSelection(); // Deseleccionar todas las filas si el texto de búsqueda está vacío
            }
            else
            {

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
                        string consulta = "INSERT INTO proveedores (ID_Proveedores, Nombre_Proveedor, Rut_Proveedor, Dirección_Proveedor, Correo_Proveedor, Telefono_Proveedor) VALUES (@id, @nombre, @rut, @direccion, @correo, @telefono)";

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
   



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                    string idProveedor = fila.Cells["ID_Proveedores"].Value.ToString();
                    string nombreProveedor = fila.Cells["Nombre_Proveedor"].Value.ToString();
                    string rutproveedor = fila.Cells["Rut_Proveedor"].Value.ToString();
                    string direccionproveedor = fila.Cells["Dirección_Proveedor"].Value.ToString();
                    string correoproveedor = fila.Cells["Correo_Proveedor"].Value.ToString();
                    string telefonoproveedor = fila.Cells["Telefono_Proveedor"].Value.ToString();

                    // Ejecutar la actualización en la base de datos
                    string consulta = "UPDATE proveedores SET Nombre_Proveedor = @nombre, Rut_Proveedor = @rut, Dirección_Proveedor = @direccion, Correo_Proveedor = @correo,Telefono_Proveedor = @fono WHERE ID_Proveedores = @id";
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@nombre", nombreProveedor);
                        comando.Parameters.AddWithValue("@rut", rutproveedor);
                        comando.Parameters.AddWithValue("@direccion", direccionproveedor);
                        comando.Parameters.AddWithValue("@correo", correoproveedor);
                        comando.Parameters.AddWithValue("@fono", telefonoproveedor);
                        comando.Parameters.AddWithValue("@id", idProveedor);
                        comando.ExecuteNonQuery();
                    }
                }


                MostrarDatos();

                conexion.Close();

                MessageBox.Show("Los registros se han actualizado correctamente.", "Actualización Existosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
