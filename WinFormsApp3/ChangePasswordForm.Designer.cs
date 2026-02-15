namespace WinFormsApp3
{
    partial class ChangePasswordForm
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
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tokentext = new Label();
            label2 = new Label();
            token = new TextBox();
            NuevaContra = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            BtnCambiar = new Button();
            label3 = new Label();
            EmailInput = new TextBox();
            panel4 = new Panel();
            btnClose = new Button();
            btnmin = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(222, 377);
            panel1.TabIndex = 0;
            panel1.MouseDown += ChangePasswordForm_MouseDown;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(44, 247);
            label1.Name = "label1";
            label1.Size = new Size(130, 66);
            label1.TabIndex = 26;
            label1.Text = "   Cambiar Contraseña";
            label1.MouseDown += ChangePasswordForm_MouseDown;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = Properties.Resources.C2sf;
            pictureBox1.Location = new Point(23, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 174);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += ChangePasswordForm_MouseDown;
            // 
            // tokentext
            // 
            tokentext.AutoSize = true;
            tokentext.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tokentext.ForeColor = SystemColors.ControlLightLight;
            tokentext.Location = new Point(289, 91);
            tokentext.Name = "tokentext";
            tokentext.Size = new Size(56, 21);
            tokentext.TabIndex = 2;
            tokentext.Text = "Token";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(289, 193);
            label2.Name = "label2";
            label2.Size = new Size(150, 21);
            label2.TabIndex = 3;
            label2.Text = "Nueva Contraseña";
            // 
            // token
            // 
            token.BackColor = Color.MediumBlue;
            token.BorderStyle = BorderStyle.None;
            token.Cursor = Cursors.IBeam;
            token.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            token.ForeColor = SystemColors.ControlLightLight;
            token.Location = new Point(289, 115);
            token.Name = "token";
            token.PlaceholderText = " Ingrese El Token";
            token.Size = new Size(279, 16);
            token.TabIndex = 4;
            token.TextChanged += token_TextChanged;
            // 
            // NuevaContra
            // 
            NuevaContra.BackColor = Color.MediumBlue;
            NuevaContra.BorderStyle = BorderStyle.None;
            NuevaContra.Cursor = Cursors.IBeam;
            NuevaContra.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NuevaContra.ForeColor = SystemColors.ControlLightLight;
            NuevaContra.Location = new Point(289, 217);
            NuevaContra.Name = "NuevaContra";
            NuevaContra.PlaceholderText = " Ingrese La Nueva Contraseña";
            NuevaContra.Size = new Size(279, 16);
            NuevaContra.TabIndex = 5;
            NuevaContra.UseSystemPasswordChar = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.ForeColor = Color.Navy;
            panel2.Location = new Point(289, 137);
            panel2.Name = "panel2";
            panel2.Size = new Size(279, 2);
            panel2.TabIndex = 23;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Navy;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.ForeColor = Color.Navy;
            panel3.Location = new Point(289, 239);
            panel3.Name = "panel3";
            panel3.Size = new Size(279, 2);
            panel3.TabIndex = 23;
            // 
            // BtnCambiar
            // 
            BtnCambiar.BackColor = Color.Navy;
            BtnCambiar.BackgroundImageLayout = ImageLayout.Center;
            BtnCambiar.Cursor = Cursors.Hand;
            BtnCambiar.FlatAppearance.BorderSize = 0;
            BtnCambiar.FlatStyle = FlatStyle.Flat;
            BtnCambiar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCambiar.ForeColor = SystemColors.ControlLightLight;
            BtnCambiar.Location = new Point(289, 275);
            BtnCambiar.Name = "BtnCambiar";
            BtnCambiar.Size = new Size(176, 38);
            BtnCambiar.TabIndex = 24;
            BtnCambiar.Text = "Cambiar Contraseña";
            BtnCambiar.UseVisualStyleBackColor = false;
            BtnCambiar.Click += cambiarcon_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(289, 142);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 25;
            label3.Text = "Email";
            // 
            // EmailInput
            // 
            EmailInput.BackColor = Color.MediumBlue;
            EmailInput.BorderStyle = BorderStyle.None;
            EmailInput.Cursor = Cursors.IBeam;
            EmailInput.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmailInput.ForeColor = SystemColors.ControlLightLight;
            EmailInput.Location = new Point(289, 166);
            EmailInput.Name = "EmailInput";
            EmailInput.PlaceholderText = " Ingrese Su Correo Electronico";
            EmailInput.Size = new Size(279, 16);
            EmailInput.TabIndex = 26;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Navy;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.ForeColor = Color.Navy;
            panel4.Location = new Point(289, 188);
            panel4.Name = "panel4";
            panel4.Size = new Size(279, 2);
            panel4.TabIndex = 24;
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
            btnClose.Location = new Point(737, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(33, 29);
            btnClose.TabIndex = 27;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
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
            btnmin.Location = new Point(698, 12);
            btnmin.Name = "btnmin";
            btnmin.Size = new Size(33, 29);
            btnmin.TabIndex = 28;
            btnmin.UseVisualStyleBackColor = false;
            btnmin.Click += btnmin_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.token_crypto_art_eth_athereum_icon_226041;
            pictureBox2.Location = new Point(235, 91);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.email_envelope_outline_shape_with_rounded_corners_icon_icons_com_56530;
            pictureBox3.Location = new Point(235, 142);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(48, 48);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 30;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.password_protect_secure_security_privacy_lock_padlock_icon_219328;
            pictureBox4.Location = new Point(235, 193);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(48, 48);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 31;
            pictureBox4.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(471, 275);
            button1.Name = "button1";
            button1.Size = new Size(97, 38);
            button1.TabIndex = 32;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumBlue;
            ClientSize = new Size(782, 377);
            Controls.Add(button1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(btnmin);
            Controls.Add(btnClose);
            Controls.Add(panel4);
            Controls.Add(EmailInput);
            Controls.Add(label3);
            Controls.Add(BtnCambiar);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(NuevaContra);
            Controls.Add(token);
            Controls.Add(label2);
            Controls.Add(tokentext);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChangePasswordForm";
            Opacity = 0.8D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CambiarContra";
            Load += CambiarContra_Load;
            MouseDown += ChangePasswordForm_MouseDown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label tokentext;
        private Label label2;
        private TextBox token;
        private TextBox NuevaContra;
        private Panel panel2;
        private Panel panel3;
        private Button BtnCambiar;
        private Label label3;
        private TextBox EmailInput;
        private Panel panel4;
        private Button btnClose;
        private Button btnmin;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button button1;
    }
}