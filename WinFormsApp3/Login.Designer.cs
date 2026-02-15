namespace WinFormsApp3
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            usuario = new TextBox();
            logintext = new Label();
            contra = new Label();
            contrasena = new TextBox();
            pictureBox1 = new PictureBox();
            loginbutton = new Button();
            registerbutton = new Button();
            btnClose = new Button();
            btnmin = new Button();
            linkLabel1 = new LinkLabel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // usuario
            // 
            usuario.BackColor = Color.MediumBlue;
            usuario.BorderStyle = BorderStyle.None;
            usuario.Cursor = Cursors.IBeam;
            usuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usuario.ForeColor = SystemColors.ControlLightLight;
            usuario.Location = new Point(307, 124);
            usuario.Name = "usuario";
            usuario.PlaceholderText = " Ingrese Su Usuario";
            usuario.Size = new Size(279, 16);
            usuario.TabIndex = 0;
            usuario.TextChanged += textBox1_TextChanged;
            // 
            // logintext
            // 
            logintext.AutoSize = true;
            logintext.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logintext.ForeColor = SystemColors.ControlLightLight;
            logintext.Location = new Point(307, 100);
            logintext.Name = "logintext";
            logintext.Size = new Size(161, 21);
            logintext.TabIndex = 1;
            logintext.Text = "Nombre De Usuario";
            // 
            // contra
            // 
            contra.AutoSize = true;
            contra.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contra.ForeColor = SystemColors.ControlLightLight;
            contra.Location = new Point(307, 162);
            contra.Name = "contra";
            contra.Size = new Size(96, 21);
            contra.TabIndex = 2;
            contra.Text = "Contraseña";
            // 
            // contrasena
            // 
            contrasena.BackColor = Color.MediumBlue;
            contrasena.BorderStyle = BorderStyle.None;
            contrasena.Cursor = Cursors.IBeam;
            contrasena.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contrasena.ForeColor = SystemColors.ControlLightLight;
            contrasena.Location = new Point(307, 186);
            contrasena.Name = "contrasena";
            contrasena.PlaceholderText = " Ingrese Su Contraseña";
            contrasena.Size = new Size(279, 16);
            contrasena.TabIndex = 3;
            contrasena.UseSystemPasswordChar = true;
            contrasena.TextChanged += contrasena_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = Properties.Resources.C2sf;
            pictureBox1.Location = new Point(22, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 174);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            pictureBox1.MouseDown += Login_MouseDown;
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
            loginbutton.Location = new Point(307, 250);
            loginbutton.Name = "loginbutton";
            loginbutton.Size = new Size(132, 31);
            loginbutton.TabIndex = 6;
            loginbutton.Text = "Acceder";
            loginbutton.UseVisualStyleBackColor = false;
            loginbutton.Click += loginbutton_Click;
            // 
            // registerbutton
            // 
            registerbutton.BackColor = Color.Navy;
            registerbutton.BackgroundImageLayout = ImageLayout.Center;
            registerbutton.Cursor = Cursors.Hand;
            registerbutton.FlatAppearance.BorderSize = 0;
            registerbutton.FlatStyle = FlatStyle.Flat;
            registerbutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerbutton.ForeColor = SystemColors.ControlLightLight;
            registerbutton.Location = new Point(454, 250);
            registerbutton.Name = "registerbutton";
            registerbutton.Size = new Size(132, 31);
            registerbutton.TabIndex = 7;
            registerbutton.Text = "Registrarse";
            registerbutton.UseVisualStyleBackColor = false;
            registerbutton.Click += registerbutton_Click;
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = Properties.Resources.Twitter_X_Logo;
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.FlatAppearance.BorderColor = Color.Navy;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 0, 0);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 0, 0);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.Red;
            btnClose.Image = Properties.Resources.Twitter_X_Logo;
            btnClose.Location = new Point(678, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(33, 29);
            btnClose.TabIndex = 19;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += button1_Click_1;
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
            btnmin.Location = new Point(639, 12);
            btnmin.Name = "btnmin";
            btnmin.Size = new Size(33, 29);
            btnmin.TabIndex = 20;
            btnmin.UseVisualStyleBackColor = false;
            btnmin.Click += button1_Click_2;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Cyan;
            linkLabel1.Location = new Point(307, 213);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(168, 15);
            linkLabel1.TabIndex = 21;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "¿Haz Olvidado Tu Contraseña?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.ForeColor = Color.Navy;
            panel1.Location = new Point(307, 146);
            panel1.Name = "panel1";
            panel1.Size = new Size(279, 2);
            panel1.TabIndex = 22;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.ForeColor = Color.Navy;
            panel2.Location = new Point(307, 208);
            panel2.Name = "panel2";
            panel2.Size = new Size(279, 2);
            panel2.TabIndex = 23;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Navy;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(215, 333);
            panel3.TabIndex = 24;
            panel3.MouseDown += Login_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(39, 227);
            label1.Name = "label1";
            label1.Size = new Size(148, 30);
            label1.TabIndex = 25;
            label1.Text = "Iniciar Sesión";
            label1.MouseDown += Login_MouseDown;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.account_avatar_face_man_people_profile_user_icon_123197;
            pictureBox2.Location = new Point(253, 100);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            pictureBox2.MouseDown += Login_MouseDown;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.password_protect_secure_security_privacy_lock_padlock_icon_219328;
            pictureBox3.Location = new Point(253, 162);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(48, 48);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 26;
            pictureBox3.TabStop = false;
            pictureBox3.MouseDown += Login_MouseDown;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumBlue;
            ClientSize = new Size(723, 333);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(linkLabel1);
            Controls.Add(btnmin);
            Controls.Add(btnClose);
            Controls.Add(registerbutton);
            Controls.Add(loginbutton);
            Controls.Add(contrasena);
            Controls.Add(contra);
            Controls.Add(logintext);
            Controls.Add(usuario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Opacity = 0.8D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Examen Unidad II";
            Load += Form1_Load;
            MouseDown += Login_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usuario;
        private Label logintext;
        private Label contra;
        private TextBox contrasena;
        private PictureBox pictureBox1;
        private Button loginbutton;
        private Button registerbutton;
        private Button btnClose;
        private Button btnmin;
        private LinkLabel linkLabel1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}
