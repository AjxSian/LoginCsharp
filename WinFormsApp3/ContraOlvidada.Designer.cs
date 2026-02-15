namespace WinFormsApp3
{
    partial class ContraOlvidada
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
            btnClose = new Button();
            email = new Label();
            Inputemail = new TextBox();
            button1 = new Button();
            btnMin = new Button();
            panel3 = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            btnClose.Location = new Point(780, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(33, 29);
            btnClose.TabIndex = 19;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // email
            // 
            email.AutoSize = true;
            email.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            email.ForeColor = SystemColors.ControlLightLight;
            email.Location = new Point(315, 123);
            email.Name = "email";
            email.Size = new Size(53, 21);
            email.TabIndex = 21;
            email.Text = "Email";
            // 
            // Inputemail
            // 
            Inputemail.BackColor = Color.MediumBlue;
            Inputemail.BorderStyle = BorderStyle.None;
            Inputemail.Cursor = Cursors.IBeam;
            Inputemail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Inputemail.ForeColor = SystemColors.ControlLightLight;
            Inputemail.Location = new Point(315, 147);
            Inputemail.Name = "Inputemail";
            Inputemail.PlaceholderText = " Ingrese Su Correo Electrónico";
            Inputemail.Size = new Size(408, 16);
            Inputemail.TabIndex = 22;
            Inputemail.TextChanged += Inputemail_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(541, 204);
            button1.Name = "button1";
            button1.Size = new Size(132, 31);
            button1.TabIndex = 25;
            button1.Text = "CambiarContraseña";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnMin
            // 
            btnMin.BackgroundImage = Properties.Resources._32320;
            btnMin.BackgroundImageLayout = ImageLayout.Stretch;
            btnMin.FlatAppearance.BorderColor = Color.Navy;
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 0, 0);
            btnMin.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 0, 0);
            btnMin.FlatStyle = FlatStyle.Flat;
            btnMin.ForeColor = Color.Red;
            btnMin.Image = Properties.Resources.Twitter_X_Logo;
            btnMin.Location = new Point(741, 12);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(33, 29);
            btnMin.TabIndex = 27;
            btnMin.UseVisualStyleBackColor = false;
            btnMin.Click += btnMin_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Navy;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(pictureBox2);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(215, 334);
            panel3.TabIndex = 28;
            panel3.MouseDown += ContraOlvidada_MouseDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(37, 227);
            label2.Name = "label2";
            label2.Size = new Size(150, 30);
            label2.TabIndex = 30;
            label2.Text = "Recuperación";
            label2.MouseDown += ContraOlvidada_MouseDown;
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
            pictureBox2.MouseDown += ContraOlvidada_MouseDown;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.ForeColor = Color.Navy;
            panel2.Location = new Point(315, 169);
            panel2.Name = "panel2";
            panel2.Size = new Size(408, 2);
            panel2.TabIndex = 29;
            // 
            // button3
            // 
            button3.BackColor = Color.Navy;
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(375, 204);
            button3.Name = "button3";
            button3.Size = new Size(132, 31);
            button3.TabIndex = 30;
            button3.Text = "Enviar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.email_envelope_outline_shape_with_rounded_corners_icon_icons_com_56530;
            pictureBox1.Location = new Point(261, 123);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += ContraOlvidada_MouseDown;
            // 
            // ContraOlvidada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumBlue;
            ClientSize = new Size(825, 334);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(btnMin);
            Controls.Add(button1);
            Controls.Add(Inputemail);
            Controls.Add(email);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ContraOlvidada";
            Opacity = 0.8D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ContraOlvidada";
            Load += ContraOlvidada_Load;
            MouseDown += ContraOlvidada_MouseDown;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Label email;
        private TextBox Inputemail;
        private Button button1;
        private Button btnMin;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Label label2;
        private Button button3;
        private PictureBox pictureBox1;
    }
}