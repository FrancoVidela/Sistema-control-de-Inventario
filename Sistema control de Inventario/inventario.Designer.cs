namespace Sistema_control_de_Inventario
{
    partial class inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inventario));
            menuStrip1 = new MenuStrip();
            stockDeProductosToolStripMenuItem = new ToolStripMenuItem();
            proveedoresToolStripMenuItem = new ToolStripMenuItem();
            informesToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesionToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            button3 = new Button();
            btn_modificar = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Highlight;
            menuStrip1.Items.AddRange(new ToolStripItem[] { stockDeProductosToolStripMenuItem, proveedoresToolStripMenuItem, informesToolStripMenuItem, cerrarSesionToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(884, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // stockDeProductosToolStripMenuItem
            // 
            stockDeProductosToolStripMenuItem.Name = "stockDeProductosToolStripMenuItem";
            stockDeProductosToolStripMenuItem.Size = new Size(121, 20);
            stockDeProductosToolStripMenuItem.Text = "Stock de productos";
            stockDeProductosToolStripMenuItem.Click += stockDeProductosToolStripMenuItem_Click;
            // 
            // proveedoresToolStripMenuItem
            // 
            proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            proveedoresToolStripMenuItem.Size = new Size(84, 20);
            proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // informesToolStripMenuItem
            // 
            informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            informesToolStripMenuItem.Size = new Size(66, 20);
            informesToolStripMenuItem.Text = "Informes";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            cerrarSesionToolStripMenuItem.Size = new Size(87, 20);
            cerrarSesionToolStripMenuItem.Text = "Cerrar sesion";
            cerrarSesionToolStripMenuItem.Click += cerrarSesionToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(41, 20);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.SeaShell;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.SkyBlue;
            dataGridView1.Location = new Point(276, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(596, 415);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(23, 102);
            groupBox1.Margin = new Padding(6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(252, 96);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtrar productos";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(137, 54);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 57);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 2;
            label2.Text = "ID del producto :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 31);
            label1.Name = "label1";
            label1.Size = new Size(128, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre del producto :";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(137, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(btn_modificar);
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(23, 207);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 110);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Modificar ";
            // 
            // button3
            // 
            button3.Location = new Point(70, 64);
            button3.Name = "button3";
            button3.Size = new Size(107, 40);
            button3.TabIndex = 2;
            button3.Text = "Agregar registro";
            button3.UseVisualStyleBackColor = true;
            // 
            // btn_modificar
            // 
            btn_modificar.Location = new Point(130, 22);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(114, 36);
            btn_modificar.TabIndex = 1;
            btn_modificar.Text = "Modificar registro";
            btn_modificar.UseVisualStyleBackColor = true;
            btn_modificar.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(6, 22);
            button1.Name = "button1";
            button1.Size = new Size(118, 36);
            button1.TabIndex = 0;
            button1.Text = "Eliminar registro";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(34, 323);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(226, 169);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Bright", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(502, 43);
            label3.Name = "label3";
            label3.Size = new Size(150, 31);
            label3.TabIndex = 6;
            label3.Text = "Productos";
            // 
            // inventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(884, 504);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "inventario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "inventario";
            FormClosing += inventario_FormClosing;
            Load += inventario_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem stockDeProductosToolStripMenuItem;
        private ToolStripMenuItem proveedoresToolStripMenuItem;
        private ToolStripMenuItem informesToolStripMenuItem;
        private ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private GroupBox groupBox2;
        private Button button3;
        private Button btn_modificar;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label3;
    }
}