namespace Parcial_N_2
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button administrador;
            System.Windows.Forms.Button btn_facturas2;
            System.Windows.Forms.Button btn_clientes2;
            System.Windows.Forms.Button btn_productos2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_administrador = new System.Windows.Forms.Button();
            this.btn_facturas = new System.Windows.Forms.Button();
            this.btn_clientes = new System.Windows.Forms.Button();
            this.btn_productos = new System.Windows.Forms.Button();
            this.logopanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelchildForm = new System.Windows.Forms.Panel();
            this.btn_salir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.DatosEmpresa = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            administrador = new System.Windows.Forms.Button();
            btn_facturas2 = new System.Windows.Forms.Button();
            btn_clientes2 = new System.Windows.Forms.Button();
            btn_productos2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.logopanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelchildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // administrador
            // 
            administrador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            administrador.Cursor = System.Windows.Forms.Cursors.Hand;
            administrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            administrador.Image = global::Parcial_N_2.Properties.Resources.settings3;
            administrador.Location = new System.Drawing.Point(193, 516);
            administrador.Margin = new System.Windows.Forms.Padding(4);
            administrador.Name = "administrador";
            administrador.Size = new System.Drawing.Size(197, 162);
            administrador.TabIndex = 13;
            administrador.UseVisualStyleBackColor = false;
            administrador.Click += new System.EventHandler(this.administrador_Click);
            // 
            // btn_facturas2
            // 
            btn_facturas2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            btn_facturas2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btn_facturas2.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_facturas2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_facturas2.Image = global::Parcial_N_2.Properties.Resources.file_invoice2;
            btn_facturas2.Location = new System.Drawing.Point(765, 250);
            btn_facturas2.Margin = new System.Windows.Forms.Padding(4);
            btn_facturas2.Name = "btn_facturas2";
            btn_facturas2.Size = new System.Drawing.Size(197, 162);
            btn_facturas2.TabIndex = 12;
            btn_facturas2.UseVisualStyleBackColor = false;
            btn_facturas2.Click += new System.EventHandler(this.btn_facturas2_Click);
            // 
            // btn_clientes2
            // 
            btn_clientes2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            btn_clientes2.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_clientes2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_clientes2.Image = global::Parcial_N_2.Properties.Resources.users_alt__1_1;
            btn_clientes2.Location = new System.Drawing.Point(488, 250);
            btn_clientes2.Margin = new System.Windows.Forms.Padding(4);
            btn_clientes2.Name = "btn_clientes2";
            btn_clientes2.Size = new System.Drawing.Size(197, 162);
            btn_clientes2.TabIndex = 11;
            btn_clientes2.UseVisualStyleBackColor = false;
            btn_clientes2.Click += new System.EventHandler(this.btn_clientes2_Click);
            // 
            // btn_productos2
            // 
            btn_productos2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            btn_productos2.BackgroundImage = global::Parcial_N_2.Properties.Resources.box3;
            btn_productos2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            btn_productos2.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_productos2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_productos2.Location = new System.Drawing.Point(193, 250);
            btn_productos2.Margin = new System.Windows.Forms.Padding(4);
            btn_productos2.Name = "btn_productos2";
            btn_productos2.Size = new System.Drawing.Size(197, 162);
            btn_productos2.TabIndex = 10;
            btn_productos2.UseVisualStyleBackColor = false;
            btn_productos2.Click += new System.EventHandler(this.btn_productos2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(176)))), ((int)(((byte)(174)))));
            this.panel1.Controls.Add(this.btn_administrador);
            this.panel1.Controls.Add(this.btn_facturas);
            this.panel1.Controls.Add(this.btn_clientes);
            this.panel1.Controls.Add(this.btn_productos);
            this.panel1.Controls.Add(this.logopanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 766);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_administrador
            // 
            this.btn_administrador.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_administrador.FlatAppearance.BorderSize = 0;
            this.btn_administrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_administrador.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_administrador.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_administrador.Location = new System.Drawing.Point(0, 366);
            this.btn_administrador.Margin = new System.Windows.Forms.Padding(4);
            this.btn_administrador.Name = "btn_administrador";
            this.btn_administrador.Size = new System.Drawing.Size(313, 49);
            this.btn_administrador.TabIndex = 19;
            this.btn_administrador.Text = "Administrador";
            this.btn_administrador.UseVisualStyleBackColor = true;
            this.btn_administrador.Click += new System.EventHandler(this.btn_administrador_Click);
            // 
            // btn_facturas
            // 
            this.btn_facturas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_facturas.FlatAppearance.BorderSize = 0;
            this.btn_facturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_facturas.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_facturas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_facturas.Location = new System.Drawing.Point(0, 317);
            this.btn_facturas.Margin = new System.Windows.Forms.Padding(4);
            this.btn_facturas.Name = "btn_facturas";
            this.btn_facturas.Size = new System.Drawing.Size(313, 49);
            this.btn_facturas.TabIndex = 18;
            this.btn_facturas.Text = "Facturas";
            this.btn_facturas.UseVisualStyleBackColor = true;
            this.btn_facturas.Click += new System.EventHandler(this.btn_facturas_Click);
            // 
            // btn_clientes
            // 
            this.btn_clientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_clientes.FlatAppearance.BorderSize = 0;
            this.btn_clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clientes.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_clientes.Location = new System.Drawing.Point(0, 268);
            this.btn_clientes.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clientes.Name = "btn_clientes";
            this.btn_clientes.Size = new System.Drawing.Size(313, 49);
            this.btn_clientes.TabIndex = 16;
            this.btn_clientes.Text = "Clientes";
            this.btn_clientes.UseVisualStyleBackColor = true;
            this.btn_clientes.Click += new System.EventHandler(this.btn_clientes_Click_1);
            // 
            // btn_productos
            // 
            this.btn_productos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_productos.FlatAppearance.BorderSize = 0;
            this.btn_productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_productos.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_productos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_productos.Location = new System.Drawing.Point(0, 219);
            this.btn_productos.Margin = new System.Windows.Forms.Padding(4);
            this.btn_productos.Name = "btn_productos";
            this.btn_productos.Size = new System.Drawing.Size(313, 49);
            this.btn_productos.TabIndex = 14;
            this.btn_productos.Text = "Productos";
            this.btn_productos.UseVisualStyleBackColor = true;
            this.btn_productos.Click += new System.EventHandler(this.btn_productos_Click_1);
            // 
            // logopanel
            // 
            this.logopanel.Controls.Add(this.pictureBox1);
            this.logopanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logopanel.Location = new System.Drawing.Point(0, 0);
            this.logopanel.Margin = new System.Windows.Forms.Padding(4);
            this.logopanel.Name = "logopanel";
            this.logopanel.Size = new System.Drawing.Size(313, 219);
            this.logopanel.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Parcial_N_2.Properties.Resources.Imagen_de_WhatsApp_2023_10_22_a_las_13_04_04_06f76646;
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelchildForm
            // 
            this.panelchildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.panelchildForm.Controls.Add(this.btn_salir);
            this.panelchildForm.Controls.Add(this.label3);
            this.panelchildForm.Controls.Add(this.pictureBox2);
            this.panelchildForm.Controls.Add(this.DatosEmpresa);
            this.panelchildForm.Controls.Add(this.pictureBox3);
            this.panelchildForm.Controls.Add(administrador);
            this.panelchildForm.Controls.Add(btn_facturas2);
            this.panelchildForm.Controls.Add(btn_clientes2);
            this.panelchildForm.Controls.Add(btn_productos2);
            this.panelchildForm.Controls.Add(this.label1);
            this.panelchildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelchildForm.Location = new System.Drawing.Point(313, 0);
            this.panelchildForm.Margin = new System.Windows.Forms.Padding(4);
            this.panelchildForm.Name = "panelchildForm";
            this.panelchildForm.Size = new System.Drawing.Size(1115, 766);
            this.panelchildForm.TabIndex = 1;
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.Transparent;
            this.btn_salir.BackgroundImage = global::Parcial_N_2.Properties.Resources.x_30465_640_removebg_preview_removebg_preview;
            this.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_salir.FlatAppearance.BorderSize = 0;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Location = new System.Drawing.Point(1031, 15);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(41, 42);
            this.btn_salir.TabIndex = 35;
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 7F);
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(878, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Datos del usuario";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Parcial_N_2.Properties.Resources.user___copia;
            this.pictureBox2.Location = new System.Drawing.Point(786, 64);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // DatosEmpresa
            // 
            this.DatosEmpresa.AutoSize = true;
            this.DatosEmpresa.Font = new System.Drawing.Font("Microsoft YaHei", 7F);
            this.DatosEmpresa.ForeColor = System.Drawing.SystemColors.GrayText;
            this.DatosEmpresa.Location = new System.Drawing.Point(575, 64);
            this.DatosEmpresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DatosEmpresa.Name = "DatosEmpresa";
            this.DatosEmpresa.Size = new System.Drawing.Size(130, 17);
            this.DatosEmpresa.TabIndex = 15;
            this.DatosEmpresa.Text = "Datos de la Empresa";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::Parcial_N_2.Properties.Resources.building__1_1;
            this.pictureBox3.Location = new System.Drawing.Point(488, 64);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(54, 54);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 45);
            this.label1.TabIndex = 9;
            this.label1.Text = "Home";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1428, 766);
            this.ControlBox = false;
            this.Controls.Add(this.panelchildForm);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Text = "Sistema de facturacion";
            this.panel1.ResumeLayout(false);
            this.logopanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelchildForm.ResumeLayout(false);
            this.panelchildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel logopanel;
        private System.Windows.Forms.Button btn_administrador;
        private System.Windows.Forms.Button btn_facturas;
        private System.Windows.Forms.Button btn_clientes;
        private System.Windows.Forms.Button btn_productos;
        private System.Windows.Forms.Panel panelchildForm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label DatosEmpresa;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

