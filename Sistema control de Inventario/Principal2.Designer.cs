﻿namespace Sistema_control_de_Inventario
{
    partial class Principal2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal2));
            MenuVertical = new Panel();
            button4 = new Button();
            btnProvee = new Button();
            btnProductos = new Button();
            btnInicio = new PictureBox();
            BarraTitulo = new Panel();
            Maximizar = new PictureBox();
            Restaurar = new PictureBox();
            Minimizar = new PictureBox();
            Cerrar = new PictureBox();
            btnMen = new PictureBox();
            PanelContenedor = new Panel();
            MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnInicio).BeginInit();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Maximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Restaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Minimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Cerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMen).BeginInit();
            SuspendLayout();
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.FromArgb(11, 7, 17);
            MenuVertical.Controls.Add(button4);
            MenuVertical.Controls.Add(btnProvee);
            MenuVertical.Controls.Add(btnProductos);
            MenuVertical.Controls.Add(btnInicio);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 0);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(250, 650);
            MenuVertical.TabIndex = 0;
            MenuVertical.Paint += MenuVertical_Paint;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button4.BackColor = Color.FromArgb(11, 7, 17);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Rockwell", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(0, 569);
            button4.Name = "button4";
            button4.Size = new Size(250, 81);
            button4.TabIndex = 5;
            button4.Text = "Cerrar \r\nSesión";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // btnProvee
            // 
            btnProvee.FlatAppearance.BorderSize = 0;
            btnProvee.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnProvee.FlatStyle = FlatStyle.Flat;
            btnProvee.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnProvee.ForeColor = Color.White;
            btnProvee.Image = (Image)resources.GetObject("btnProvee.Image");
            btnProvee.ImageAlign = ContentAlignment.MiddleLeft;
            btnProvee.Location = new Point(0, 152);
            btnProvee.Name = "btnProvee";
            btnProvee.Size = new Size(250, 50);
            btnProvee.TabIndex = 2;
            btnProvee.Text = "Proveedor";
            btnProvee.UseVisualStyleBackColor = true;
            btnProvee.Click += button1_Click;
            // 
            // btnProductos
            // 
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnProductos.ForeColor = Color.White;
            btnProductos.Image = (Image)resources.GetObject("btnProductos.Image");
            btnProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductos.Location = new Point(0, 101);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(250, 50);
            btnProductos.TabIndex = 1;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnInicio
            // 
            btnInicio.Image = (Image)resources.GetObject("btnInicio.Image");
            btnInicio.Location = new Point(0, 0);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(218, 66);
            btnInicio.SizeMode = PictureBoxSizeMode.Zoom;
            btnInicio.TabIndex = 0;
            btnInicio.TabStop = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.FromArgb(11, 7, 17);
            BarraTitulo.Controls.Add(Maximizar);
            BarraTitulo.Controls.Add(Restaurar);
            BarraTitulo.Controls.Add(Minimizar);
            BarraTitulo.Controls.Add(Cerrar);
            BarraTitulo.Controls.Add(btnMen);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(250, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(1050, 50);
            BarraTitulo.TabIndex = 1;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // Maximizar
            // 
            Maximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Maximizar.Cursor = Cursors.Hand;
            Maximizar.Image = (Image)resources.GetObject("Maximizar.Image");
            Maximizar.Location = new Point(981, 12);
            Maximizar.Name = "Maximizar";
            Maximizar.Size = new Size(20, 20);
            Maximizar.SizeMode = PictureBoxSizeMode.Zoom;
            Maximizar.TabIndex = 4;
            Maximizar.TabStop = false;
            Maximizar.Click += Maximizar_Click;
            // 
            // Restaurar
            // 
            Restaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Restaurar.Cursor = Cursors.Hand;
            Restaurar.Image = (Image)resources.GetObject("Restaurar.Image");
            Restaurar.Location = new Point(981, 12);
            Restaurar.Name = "Restaurar";
            Restaurar.Size = new Size(20, 20);
            Restaurar.SizeMode = PictureBoxSizeMode.Zoom;
            Restaurar.TabIndex = 3;
            Restaurar.TabStop = false;
            Restaurar.Click += Restaurar_Click;
            // 
            // Minimizar
            // 
            Minimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Minimizar.Cursor = Cursors.Hand;
            Minimizar.Image = (Image)resources.GetObject("Minimizar.Image");
            Minimizar.Location = new Point(942, 12);
            Minimizar.Name = "Minimizar";
            Minimizar.Size = new Size(20, 20);
            Minimizar.SizeMode = PictureBoxSizeMode.Zoom;
            Minimizar.TabIndex = 2;
            Minimizar.TabStop = false;
            Minimizar.Click += Minimizar_Click;
            // 
            // Cerrar
            // 
            Cerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Cerrar.Cursor = Cursors.Hand;
            Cerrar.Image = (Image)resources.GetObject("Cerrar.Image");
            Cerrar.Location = new Point(1018, 12);
            Cerrar.Name = "Cerrar";
            Cerrar.Size = new Size(20, 20);
            Cerrar.SizeMode = PictureBoxSizeMode.Zoom;
            Cerrar.TabIndex = 1;
            Cerrar.TabStop = false;
            Cerrar.Click += Cerrar_Click;
            // 
            // btnMen
            // 
            btnMen.Cursor = Cursors.Hand;
            btnMen.Image = (Image)resources.GetObject("btnMen.Image");
            btnMen.Location = new Point(16, 9);
            btnMen.Name = "btnMen";
            btnMen.Size = new Size(35, 35);
            btnMen.SizeMode = PictureBoxSizeMode.Zoom;
            btnMen.TabIndex = 0;
            btnMen.TabStop = false;
            btnMen.Click += btnMen_Click;
            // 
            // PanelContenedor
            // 
            PanelContenedor.BackColor = Color.FromArgb(11, 7, 17);
            PanelContenedor.Dock = DockStyle.Fill;
            PanelContenedor.Location = new Point(250, 50);
            PanelContenedor.Name = "PanelContenedor";
            PanelContenedor.Size = new Size(1050, 600);
            PanelContenedor.TabIndex = 2;
            PanelContenedor.Paint += PanelContenedor_Paint;
            // 
            // Principal2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 650);
            Controls.Add(PanelContenedor);
            Controls.Add(BarraTitulo);
            Controls.Add(MenuVertical);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Principal2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            Load += Principal_Load;
            MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnInicio).EndInit();
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Maximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Restaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Minimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Cerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel MenuVertical;
        private PictureBox btnInicio;
        private Button btnProductos;
        private Button btnProvee;
        private Button button4;
        private Panel BarraTitulo;
        private PictureBox btnMen;
        private Panel PanelContenedor;
        private PictureBox Maximizar;
        private PictureBox Restaurar;
        private PictureBox Minimizar;
        private PictureBox Cerrar;
    }
}