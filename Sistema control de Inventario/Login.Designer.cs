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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btniniciar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(723, 13);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(83, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(27, 26);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(472, 353);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(602, 99);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 19);
            label1.TabIndex = 2;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SeaShell;
            label2.Font = new Font("Bahnschrift Condensed", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(548, 74);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(147, 41);
            label2.TabIndex = 3;
            label2.Text = "Bienvenido!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiLight Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(547, 136);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(53, 19);
            label3.TabIndex = 4;
            label3.Text = "Usuario:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiLight Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(547, 236);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(74, 19);
            label4.TabIndex = 5;
            label4.Text = "Contraseña:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.SeaShell;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(547, 168);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(188, 21);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.SeaShell;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(547, 269);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(188, 21);
            textBox2.TabIndex = 9;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // btniniciar
            // 
            btniniciar.BackColor = Color.SeaShell;
            btniniciar.BackgroundImageLayout = ImageLayout.None;
            btniniciar.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btniniciar.Location = new Point(583, 317);
            btniniciar.Margin = new Padding(2);
            btniniciar.Name = "btniniciar";
            btniniciar.Size = new Size(116, 51);
            btniniciar.TabIndex = 10;
            btniniciar.Text = "Iniciar Sesión";
            btniniciar.UseVisualStyleBackColor = false;
            btniniciar.Click += button1_Click_1;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(832, 408);
            Controls.Add(btniniciar);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Margin = new Padding(2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btniniciar;
    }
}