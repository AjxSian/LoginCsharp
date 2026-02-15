using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace WinFormsApp3
{
    public partial class Login : Form
    {
        public static class HashHelper
        {
            public static string ComputeSha256Hash(string rawData)
            {
                using (SHA256 sha256Hash = SHA256.Create())
                {
                    byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                    StringBuilder builder = new StringBuilder();
                    foreach (byte b in bytes)
                        builder.Append(b.ToString("x2")); // Formato hexadecimal
                    return builder.ToString();
                }
            }
        }
        public Login()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void registerbutton_Click(object sender, EventArgs e)
        {
            RegistroForm registro = new RegistroForm(); // instancia del nuevo formulario
            registro.Show(); // muestra el nuevo formulario
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit(); // cierra la aplicación
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void contrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ContraOlvidada contraOlvidada = new ContraOlvidada(); // instancia del nuevo formulario
            contraOlvidada.Show(); // muestra el nuevo formulario
            this.Hide();
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            string nombre, contra;
            nombre = usuario.Text;
            contra = HashHelper.ComputeSha256Hash(contrasena.Text); // encriptamos la contraseña

            MySqlConnection conexion = new MySqlConnection("server=127.0.0.1; database=usuarios; User id=root; password=sianghost+24;");
            try
            {
                conexion.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de conexion");
                return;
            }

            string sql = "SELECT * FROM users WHERE UserName = @nombre AND Contra = @contra";
            MySqlCommand cmd = new MySqlCommand(sql, conexion);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@contra", contra); 

            MySqlDataReader read = cmd.ExecuteReader();

            if (read.Read())
            {
                this.Hide();
                MessageBox.Show("Bienvenido " + nombre);
                Interfaz interfaz = new Interfaz(); // instancia del nuevo formulario
                interfaz.Show(); // muestra el nuevo formulario
            }
            else
            {
                MessageBox.Show("No existe el usuario " + nombre);
            }
        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            usuario.Clear();
            contrasena.Clear();
            this.Show();
        }
    }
}

