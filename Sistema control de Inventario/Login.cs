﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using System.Runtime.InteropServices;

namespace Sistema_control_de_Inventario
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void button1_Click_1(object sender, EventArgs e)

        {
            string servidor = "127.0.0.1";
            string puerto = "3306";
            string inventario = "root";
            string clave = "";

            string user = textBox1.Text;
            string pd = txtContraseña.Text;
            conexion con = new conexion(user,pd);
            if (string.IsNullOrEmpty(user) && string.IsNullOrEmpty(pd))
            {
                MessageBox.Show("Los datos estan vacios");

            }
            else
            {
                int resultado = con.Conexion();
               if(resultado==1)
                {       
                  
                
                MessageBox.Show("USUARIO CORRECTO, BIENVENIDO");
                    this.Hide();
                    string tipoCuenta = con.ObtenerTipoCuenta(user);
                    if (tipoCuenta == "admin")
                    {
                        Principal adminForm = new Principal();
                        adminForm.Show();
                    }
                    else
                    {
                        Principal2 usuarioForm = new Principal2();
                        usuarioForm.Show();
                    }
                }
               else
                {
                   
                    textBox1.Text = "";
                    txtContraseña.Text = "";
                    pbUsuario.Image = Properties.Resources.incorrecto;
                    pbContraseña.Image = Properties.Resources.incorrecto;
                }


            }


        }



        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private bool mostrarContrasena = false;

        private void btnMostrarCon_Click(object sender, EventArgs e)
        {
            if (mostrarContrasena)
            {
                txtContraseña.UseSystemPasswordChar = true;
                btnMostrarCon.Image = Properties.Resources.ocultar; 
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = false;

                btnMostrarCon.Image = Properties.Resources.mostrar; 
            }

            mostrarContrasena = !mostrarContrasena; 
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            if (txtContraseña.Text.Length>0)
            {
                btnMostrarCon.Visible = true;
            }
            else
            {
                btnMostrarCon.Visible = false;
            }
        }
    }
}
