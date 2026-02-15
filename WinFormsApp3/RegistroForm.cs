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
using System.Security.Cryptography; 

namespace WinFormsApp3

{
    public partial class RegistroForm : Form
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
        public RegistroForm()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void logintext_Click(object sender, EventArgs e)
        {

        }

        private void contrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void Inputemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void contra_Click(object sender, EventArgs e)
        {

        }

        private void email_Click(object sender, EventArgs e)
        {

        }

        private void usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Crearcuenta_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection("server=127.0.0.1; database=usuarios; User id=root; password=sianghost+24;");
            try
            {
                conexion.Open();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de conexion");
                throw;
            }
            // Obtener los datos del formulario
            string nombre = usuario.Text;
            string contraOriginal = contrasena.Text;
            string email = Inputemail.Text;

            // Encriptamos la contraseña con SHA-256
            string contraHasheada = HashHelper.ComputeSha256Hash(contraOriginal);

            // Se prepara consulta con parámetros
            string sql = "INSERT INTO users (UserName, Contra, Email) VALUES (@nombre, @contra, @correo)";
            MySqlCommand cmd = new MySqlCommand(sql, conexion);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@contra", contraHasheada);
            cmd.Parameters.AddWithValue("@correo", email);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario registrado correctamente");
                this.Hide();
                Login login = new Login();
                login.Show();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al registrar el usuario: " + ex.Message);
            }
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); // cierra la aplicación
        }

        private void RegistroForm_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void RegistroForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}


