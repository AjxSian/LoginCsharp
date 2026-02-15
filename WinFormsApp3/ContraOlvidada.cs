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
using System.Net.Mail;
using System.Net;


namespace WinFormsApp3
{
    public partial class ContraOlvidada : Form
    {
        private string Conexion = "server=127.0.0.1;database=usuarios;User id=root;password=sianghost+24;";
        public void EnviarToken(string email)
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(Conexion))
                {
                    conexion.Open();
                    using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM users WHERE Email = @email", conexion))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            string token = Guid.NewGuid().ToString();
                            DateTime expiration = DateTime.Now.AddMinutes(15);
                            using (MySqlCommand EliminarCMD = new MySqlCommand("DELETE FROM tokens WHERE email = @email", conexion))
                            {
                                EliminarCMD.Parameters.AddWithValue("@email", email);
                                EliminarCMD.ExecuteNonQuery();
                            }
                            using (MySqlCommand cmdInsert = new MySqlCommand("INSERT INTO tokens (email, token, expiration) VALUES (@email, @token, @expiration)", conexion))
                            {
                                cmdInsert.Parameters.AddWithValue("@email", email);
                                cmdInsert.Parameters.AddWithValue("@token", token);
                                cmdInsert.Parameters.AddWithValue("@expiration", expiration);
                                cmdInsert.ExecuteNonQuery();
                            }
                            EnviarCorreo(email, token);
                            MessageBox.Show("Se ha enviado un correo electrónico con instrucciones para restablecer su contraseña.");
                            this.Hide();
                            ChangePasswordForm changePasswordForm = new ChangePasswordForm();
                            changePasswordForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("El correo electrónico no está registrado en el sistema.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error General: {ex.Message}");
            }
        }
        private void EnviarCorreo(string email, string token)
        {
            MailMessage mail = new MailMessage("sistemasoportetienda30@gmail.com", email);
            mail.Subject = "Token Temporal De Recuperación De Contraseña";
            mail.Body = $"Su token temporal es: {token}. Este token es válido por 15 minutos.";

            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.Credentials = new NetworkCredential("sistemasoportetienda30@gmail.com", "dlib lwnf ndnn dhud");
            client.EnableSsl = true;

            client.Send(mail);
        }
        public ContraOlvidada()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // oculta el formulario actual
            ChangePasswordForm changePasswordForm = new ChangePasswordForm();
            changePasswordForm.Show(); // muestra el nuevo formulario
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistroForm registro = new RegistroForm(); // instancia del nuevo formulario
            registro.Show(); // muestra el nuevo formulario
            this.Hide(); // oculta el formulario actual
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit(); // cierra la aplicación
        }

        private void ContraOlvidada_Load(object sender, EventArgs e)
        {

        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ContraOlvidada_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string correoo = Inputemail.Text;
            EnviarToken(correoo);
        }

        private void Inputemail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
