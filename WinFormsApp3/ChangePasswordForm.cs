using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Runtime.InteropServices;

namespace WinFormsApp3
{
    public partial class ChangePasswordForm : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private string Conexion = "server=127.0.0.1;database=usuarios;User id=root;password=sianghost+24;";
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
        public void CambiarPassword(string email, string token, string nuevacontra)
        {
            using (MySqlConnection conex = new MySqlConnection(Conexion))
            {
                conex.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT Expiration FROM Tokens WHERE Email = @email AND Token = @token", conex);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@token", token);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    DateTime expiration = Convert.ToDateTime(result);
                    if (DateTime.Now <= expiration)
                    {
                        string HashContra = HashHelper.ComputeSha256Hash(nuevacontra);
                        MySqlCommand cmdUpdate = new MySqlCommand("UPDATE users SET contra = @contrasena WHERE email = @email", conex);
                        cmdUpdate.Parameters.AddWithValue("@contrasena", HashContra);
                        cmdUpdate.Parameters.AddWithValue("@email", email);
                        cmdUpdate.ExecuteNonQuery();
                        MessageBox.Show("Contraseña actualizada correctamente.");
                        this.Hide();
                        Login login = new Login(); // instancia del nuevo formulario
                        login.Show(); // muestra el nuevo formulario
                    }
                    else
                    {
                        MessageBox.Show("El token ha expirado.");
                    }
                }
                else
                {
                    MessageBox.Show("El token no es válido o ha expirado.");
                }

            }
        }
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void cambiarcon_Click(object sender, EventArgs e)
        {
            string tokenn = token.Text;
            string email = EmailInput.Text;
            string nuevacontraA = NuevaContra.Text;
            CambiarPassword(email, tokenn, nuevacontraA);
        }

        private void CambiarContra_Load(object sender, EventArgs e)
        {

        }

        private void token_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit(); // cierra la aplicación
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // Minimiza la ventana
        }

        private void ChangePasswordForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
        }
    }
}
