namespace WinFormsApp3
{
    partial class RegistroForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroForm));
            Crearcuenta = new Button();
            loginbutton = new Button();
            pictureBox1 = new PictureBox();
            contralinktext = new LinkLabel();
            contrasena = new TextBox();
            contra = new Label();
            Usernameregister = new Label();
            usuario = new TextBox();
            email = new Label();
            Inputemail = new TextBox();
            btnClose = new Button();
            btnmin = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // Crearcuenta
            // 
            Crearcuenta.BackColor = Color.Navy;
            Crearcuenta.BackgroundImageLayout = ImageLayout.Center;
            Crearcuenta.Cursor = Cursors.Hand;
            Crearcuenta.FlatAppearance.BorderSize = 0;
            Crearcuenta.FlatStyle = FlatStyle.Flat;
            Crearcuenta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Crearcuenta.ForeColor = SystemColors.ControlLightLight;
            Crearcuenta.Location = new Point(302, 245);
            Crearcuenta.Name = "Crearcuenta";
            Crearcuenta.Size = new Size(132, 31);
            Crearcuenta.TabIndex = 15;
            Crearcuenta.Text = "Crear";
            Crearcuenta.UseVisualStyleBackColor = false;
            Crearcuenta.Click += Crearcuenta_Click;
            // 
            // loginbutton
            // 
            loginbutton.BackColor = Color.Navy;
            loginbutton.BackgroundImageLayout = ImageLayout.Center;
            loginbutton.Cursor = Cursors.Hand;
            loginbutton.FlatAppearance.BorderSize = 0;
            loginbutton.FlatStyle = FlatStyle.Flat;
            loginbutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginbutton.ForeColor = SystemColors.ControlLightLight;
            loginbutton.Location = new Point(449, 245);
            loginbutton.Name = "loginbutton";
            loginbutton.Size = new Size(132, 31);
            loginbutton.TabIndex = 14;
            loginbutton.Text = "Iniciar Sesión";
            loginbutton.UseVisualStyleBackColor = false;
            loginbutton.Click += loginbutton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 174);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += RegistroForm_MouseDown;
            // 
            // contralinktext
            // 
            contralinktext.ActiveLinkColor = Color.Purple;
            contralinktext.AutoSize = true;
            contralinktext.Cursor = Cursors.Hand;
            contralinktext.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contralinktext.Location = new Point(216, 207);
            contralinktext.Name = "contralinktext";
            contralinktext.Size = new Size(0, 17);
            contralinktext.TabIndex = 12;
            // 
            // contrasena
            // 
            contrasena.BackColor = Color.MediumBlue;
            contrasena.BorderStyle = BorderStyle.None;
            contrasena.Cursor = Cursors.IBeam;
            contrasena.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contrasena.ForeColor = SystemColors.ControlLightLight;
            contrasena.Location = new Point(302, 201);
            contrasena.Name = "contrasena";
            contrasena.PlaceholderText = " Ingrese Su Contraseña";
            contrasena.Size = new Size(279, 16);
            contrasena.TabIndex = 11;
            contrasena.UseSystemPasswordChar = true;
            contrasena.TextChanged += contrasena_TextChanged;
            // 
            // contra
            // 
            contra.AutoSize = true;
            contra.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contra.ForeColor = SystemColors.ControlLightLight;
            contra.Location = new Point(302, 177);
            contra.Name = "contra";
            contra.Size = new Size(96, 21);
            contra.TabIndex = 10;
            contra.Text = "Contraseña";
            contra.Click += contra_Click;
            // 
            // Usernameregister
            // 
            Usernameregister.AutoSize = true;
            Usernameregister.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Usernameregister.ForeColor = SystemColors.ControlLightLight;
            Usernameregister.Location = new Point(302, 49);
            Usernameregister.Name = "Usernameregister";
            Usernameregister.Size = new Size(161, 21);
            Usernameregister.TabIndex = 9;
            Usernameregister.Text = "Nombre De Usuario";
            Usernameregister.Click += logintext_Click;
            // 
            // usuario
            // 
            usuario.BackColor = Color.MediumBlue;
            usuario.BorderStyle = BorderStyle.None;
            usuario.Cursor = Cursors.IBeam;
            usuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usuario.ForeColor = SystemColors.ControlLightLight;
            usuario.Location = new Point(302, 72);
            usuario.Name = "usuario";
            usuario.PlaceholderText = " Ingrese Su Nombre De Usuario";
            usuario.Size = new Size(279, 16);
            usuario.TabIndex = 8;
            usuario.TextChanged += usuario_TextChanged;
            // 
            // email
            // 
            email.AutoSize = true;
            email.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            email.ForeColor = SystemColors.ControlLightLight;
            email.Location = new Point(302, 111);
            email.Name = "email";
            email.Size = new Size(53, 21);
            email.TabIndex = 16;
            email.Text = "Email";
            email.Click += email_Click;
            // 
            // Inputemail
            // 
            Inputemail.BackColor = Color.MediumBlue;
            Inputemail.BorderStyle = BorderStyle.None;
            Inputemail.Cursor = Cursors.IBeam;
            Inputemail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Inputemail.ForeColor = SystemColors.ControlLightLight;
            Inputemail.Location = new Point(302, 135);
            Inputemail.Name = "Inputemail";
            Inputemail.PlaceholderText = " Ingrese Su Correo Electrónico";
            Inputemail.Size = new Size(279, 16);
            Inputemail.TabIndex = 17;
            Inputemail.TextChanged += Inputemail_TextChanged;
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = Properties.Resources.Twitter_X_Logo;
            btnClose.BackgroundImageLayout = ImageLayout.Stretch;
            btnClose.FlatAppearance.BorderColor = Color.Navy;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 0, 0);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 0, 0);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.Red;
            btnClose.Image = Properties.Resources.Twitter_X_Logo;
            btnClose.Location = new Point(680, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(33, 29);
            btnClose.TabIndex = 18;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += button1_Click;
            // 
            // btnmin
            // 
            btnmin.BackgroundImage = Properties.Resources._32320;
            btnmin.BackgroundImageLayout = ImageLayout.Stretch;
            btnmin.FlatAppearance.BorderColor = Color.Navy;
            btnmin.FlatAppearance.BorderSize = 0;
            btnmin.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 0, 0);
            btnmin.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 0, 0);
            btnmin.FlatStyle = FlatStyle.Flat;
            btnmin.ForeColor = Color.Red;
            btnmin.Image = Properties.Resources.Twitter_X_Logo;
            btnmin.Location = new Point(641, 12);
            btnmin.Name = "btnmin";
            btnmin.Size = new Size(33, 29);
            btnmin.TabIndex = 21;
            btnmin.UseVisualStyleBackColor = false;
            btnmin.Click += button1_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.ForeColor = Color.Navy;
            panel1.Location = new Point(302, 95);
            panel1.Name = "panel1";
            panel1.Size = new Size(279, 2);
            panel1.TabIndex = 23;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.ForeColor = Color.Navy;
            panel2.Location = new Point(302, 157);
            panel2.Name = "panel2";
            panel2.Size = new Size(279, 2);
            panel2.TabIndex = 24;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Navy;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.ForeColor = Color.Navy;
            panel3.Location = new Point(302, 223);
            panel3.Name = "panel3";
            panel3.Size = new Size(279, 2);
            panel3.TabIndex = 25;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Navy;
            panel4.Controls.Add(label1);
            panel4.Controls.Add(pictureBox2);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(215, 333);
            panel4.TabIndex = 26;
            panel4.MouseDown += RegistroForm_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(46, 223);
            label1.Name = "label1";
            label1.Size = new Size(129, 30);
            label1.TabIndex = 27;
            label1.Text = "Registrarse";
            label1.MouseDown += RegistroForm_MouseDown;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Image = Properties.Resources.C2sf;
            pictureBox2.Location = new Point(22, 83);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(175, 174);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.MouseDown += RegistroForm_MouseDown;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.account_avatar_face_man_people_profile_user_icon_123197;
            pictureBox3.Location = new Point(248, 49);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(48, 48);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 27;
            pictureBox3.TabStop = false;
            pictureBox3.MouseDown += RegistroForm_MouseDown;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.email_envelope_outline_shape_with_rounded_corners_icon_icons_com_56530;
            pictureBox4.Location = new Point(248, 111);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(48, 48);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 28;
            pictureBox4.TabStop = false;
            pictureBox4.MouseDown += RegistroForm_MouseDown;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.password_protect_secure_security_privacy_lock_padlock_icon_219328;
            pictureBox5.Location = new Point(248, 177);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(48, 48);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 29;
            pictureBox5.TabStop = false;
            pictureBox5.MouseDown += RegistroForm_MouseDown;
            // 
            // RegistroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumBlue;
            ClientSize = new Size(725, 333);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnmin);
            Controls.Add(btnClose);
            Controls.Add(Inputemail);
            Controls.Add(email);
            Controls.Add(Crearcuenta);
            Controls.Add(loginbutton);
            Controls.Add(pictureBox1);
            Controls.Add(contralinktext);
            Controls.Add(contrasena);
            Controls.Add(contra);
            Controls.Add(Usernameregister);
            Controls.Add(usuario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistroForm";
            Opacity = 0.8D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistroForm";
            Load += RegistroForm_Load;
            MouseDown += RegistroForm_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Crearcuenta;
        private Button loginbutton;
        private PictureBox pictureBox1;
        private LinkLabel contralinktext;
        private TextBox contrasena;
        private Label contra;
        private Label Usernameregister;
        private TextBox usuario;
        private Label email;
        private TextBox Inputemail;
        private Button btnClose;
        private Button btnmin;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}