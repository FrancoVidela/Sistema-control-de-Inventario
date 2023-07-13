namespace Sistema_control_de_Inventario
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            txtContraseña = new TextBox();
            btniniciar = new Button();
            panel1 = new Panel();
            pictureBox5 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pbUsuario = new PictureBox();
            pbContraseña = new PictureBox();
            btnMostrarCon = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbContraseña).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMostrarCon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(860, 165);
            label1.Name = "label1";
            label1.Size = new Size(0, 29);
            label1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(34, 36, 49);
            label2.Font = new Font("Bahnschrift Condensed", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 122, 204);
            label2.Location = new Point(457, 27);
            label2.Name = "label2";
            label2.Size = new Size(221, 60);
            label2.TabIndex = 3;
            label2.Text = "BIENVENIDO!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(34, 36, 49);
            label3.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(361, 111);
            label3.Name = "label3";
            label3.Size = new Size(126, 32);
            label3.TabIndex = 4;
            label3.Text = "USUARIO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(34, 36, 49);
            label4.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(361, 248);
            label4.Name = "label4";
            label4.Size = new Size(168, 32);
            label4.TabIndex = 5;
            label4.Text = "CONTRASEÑA:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(28, 41, 86);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(457, 170);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(267, 28);
            textBox1.TabIndex = 8;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = Color.FromArgb(28, 41, 86);
            txtContraseña.BorderStyle = BorderStyle.None;
            txtContraseña.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtContraseña.ForeColor = Color.White;
            txtContraseña.Location = new Point(457, 304);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(267, 28);
            txtContraseña.TabIndex = 9;
            txtContraseña.UseSystemPasswordChar = true;
            txtContraseña.TextChanged += txtContraseña_TextChanged;
            // 
            // btniniciar
            // 
            btniniciar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btniniciar.BackColor = Color.FromArgb(0, 122, 204);
            btniniciar.BackgroundImageLayout = ImageLayout.None;
            btniniciar.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btniniciar.FlatAppearance.BorderSize = 0;
            btniniciar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btniniciar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btniniciar.FlatStyle = FlatStyle.Flat;
            btniniciar.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btniniciar.ForeColor = Color.FromArgb(34, 36, 49);
            btniniciar.Location = new Point(457, 391);
            btniniciar.Name = "btniniciar";
            btniniciar.Size = new Size(240, 85);
            btniniciar.TabIndex = 10;
            btniniciar.Text = "INICIAR SESIÓN";
            btniniciar.UseVisualStyleBackColor = false;
            btniniciar.Click += button1_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Controls.Add(pictureBox5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(286, 511);
            panel1.TabIndex = 11;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(46, 111);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(191, 286);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(821, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(20, 20);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            pictureBox3.MouseEnter += pictureBox3_MouseEnter;
            pictureBox3.MouseLeave += pictureBox3_MouseLeave;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(795, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(20, 20);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 15;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(361, 160);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(61, 50);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 16;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(361, 295);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(61, 50);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 17;
            pictureBox7.TabStop = false;
            // 
            // pbUsuario
            // 
            pbUsuario.BackColor = Color.Transparent;
            pbUsuario.Image = Properties.Resources.correcto;
            pbUsuario.Location = new Point(442, 160);
            pbUsuario.Name = "pbUsuario";
            pbUsuario.Size = new Size(295, 50);
            pbUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUsuario.TabIndex = 18;
            pbUsuario.TabStop = false;
            // 
            // pbContraseña
            // 
            pbContraseña.BackColor = Color.Transparent;
            pbContraseña.Image = Properties.Resources.correcto;
            pbContraseña.Location = new Point(443, 294);
            pbContraseña.Name = "pbContraseña";
            pbContraseña.Size = new Size(294, 50);
            pbContraseña.SizeMode = PictureBoxSizeMode.StretchImage;
            pbContraseña.TabIndex = 19;
            pbContraseña.TabStop = false;
            // 
            // btnMostrarCon
            // 
            btnMostrarCon.Cursor = Cursors.Hand;
            btnMostrarCon.Image = Properties.Resources.ocultar;
            btnMostrarCon.Location = new Point(754, 294);
            btnMostrarCon.Name = "btnMostrarCon";
            btnMostrarCon.Size = new Size(44, 49);
            btnMostrarCon.SizeMode = PictureBoxSizeMode.Zoom;
            btnMostrarCon.TabIndex = 21;
            btnMostrarCon.TabStop = false;
            btnMostrarCon.Visible = false;
            btnMostrarCon.Click += btnMostrarCon_Click;
            // 
            // Login
            // 
            AcceptButton = btniniciar;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 36, 49);
            ClientSize = new Size(853, 511);
            Controls.Add(btnMostrarCon);
            Controls.Add(txtContraseña);
            Controls.Add(pbContraseña);
            Controls.Add(textBox1);
            Controls.Add(pbUsuario);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(btniniciar);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            MouseDown += Login_MouseDown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbContraseña).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMostrarCon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox txtContraseña;
        private Button btniniciar;
        private Panel panel1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pbUsuario;
        private PictureBox pbContraseña;
        private PictureBox btnMostrarCon;
    }
}