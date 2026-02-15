namespace WinFormsApp3
{
    partial class Interfaz
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
            label2 = new Label();
            btnClose = new Button();
            btnmin = new Button();
            panel1 = new Panel();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Black", 63.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(247, 44);
            label2.Name = "label2";
            label2.Size = new Size(527, 382);
            label2.TabIndex = 26;
            label2.Text = "Bienvenido Al Programa";
            label2.MouseDown += Interfaz_MouseDown;
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
            btnClose.Location = new Point(755, 12);
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
            btnmin.Location = new Point(716, 12);
            btnmin.Name = "btnmin";
            btnmin.Size = new Size(33, 29);
            btnmin.TabIndex = 28;
            btnmin.UseVisualStyleBackColor = false;
            btnmin.Click += btnmin_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(213, 450);
            panel1.TabIndex = 29;
            panel1.MouseDown += Interfaz_MouseDown;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Image = Properties.Resources.logout_icon_151219;
            button1.Location = new Point(0, 406);
            button1.Name = "button1";
            button1.Size = new Size(213, 44);
            button1.TabIndex = 7;
            button1.Text = "Cerrar Sesión";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Image = Properties.Resources.C2sf;
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(175, 174);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.MouseDown += Interfaz_MouseDown;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(0, 212);
            button2.Name = "button2";
            button2.Size = new Size(213, 44);
            button2.TabIndex = 8;
            button2.Text = "Proximamente...";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(0, 262);
            button3.Name = "button3";
            button3.Size = new Size(213, 44);
            button3.TabIndex = 9;
            button3.Text = "Proximamente...";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(0, 312);
            button4.Name = "button4";
            button4.Size = new Size(213, 44);
            button4.TabIndex = 10;
            button4.Text = "Proximamente...";
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = true;
            // 
            // Interfaz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(btnmin);
            Controls.Add(btnClose);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Interfaz";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Interfaz";
            MouseDown += Interfaz_MouseDown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Button btnClose;
        private Button btnmin;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Button button1;
        private Button button3;
        private Button button2;
        private Button button4;
    }
}