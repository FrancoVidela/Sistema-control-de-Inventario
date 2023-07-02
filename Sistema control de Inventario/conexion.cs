using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_control_de_Inventario
{

    public class conexion
    {
        string servidor = "127.0.0.1";
        string puerto = "3306";
        string inventario = "root";
        string clave = "";
        string usuario;
        string pass;

        public conexion(string usuario, string pass)
        {
            this.usuario = usuario;
            this.pass = pass;
        }

       

        public int Conexion()
        {
             
                string cadena = "server =" + servidor + ";port=" + puerto + ";user id=" + inventario + ";password=" + clave + ";database=inventario";

                string consulta = "SELECT usuario, contraseña FROM login where " + "usuario='" + this.usuario + "'and contraseña='" + this.pass + "'"; 
                               
                MySqlConnection conectar = new MySqlConnection(cadena);
                MySqlCommand comando = new MySqlCommand(consulta, conectar);
                comando.CommandTimeout = 60;
                MySqlDataReader leer;
            try
            {
                conectar.Open();

                leer = comando.ExecuteReader();
                if(leer.HasRows)
                {
                   
                    //inventario inv =new inventario();
                    //inv.Show();
                    return 1;
                }
                else
                {
                    MessageBox.Show("USUARIO O CONTRASEÑA INCORRECTOS, INTENTE DE NUEVO");
                    return 0;
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            return 0;
                 


                





               

      






        }
        public string ObtenerTipoCuenta(string usuario)
        {
            string tipoCuenta = string.Empty;
            string cadena = "server =" + servidor + ";port=" + puerto + ";user id=" + inventario + ";password=" + clave + ";database=inventario";
            string consulta = "SELECT nombre_tipo FROM login WHERE usuario='" + usuario + "'";
            MySqlConnection conectar = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand(consulta, conectar);
            comando.CommandTimeout = 60;
            MySqlDataReader leer;

            try
            {
                conectar.Open();
                leer = comando.ExecuteReader();

                if (leer.Read())
                {
                    tipoCuenta = leer.GetString("nombre_tipo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conectar.Close();
            }

            return tipoCuenta;
        }

    }
}
