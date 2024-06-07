namespace Parcial_N_2
{
    partial class facturasForm
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
            this.btn_create = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DatosEmpresa = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_salir = new System.Windows.Forms.Button();
            this.listFacturaGeneral = new System.Windows.Forms.ListView();
            this.columnCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPago = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMonto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rbAscendente = new System.Windows.Forms.RadioButton();
            this.rbDescendente = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_create
            // 
            this.btn_create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(186)))));
            this.btn_create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_create.FlatAppearance.BorderSize = 0;
            this.btn_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_create.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.Location = new System.Drawing.Point(884, 156);
            this.btn_create.Margin = new System.Windows.Forms.Padding(4);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(188, 41);
            this.btn_create.TabIndex = 42;
            this.btn_create.Text = "+Crear";
            this.btn_create.UseVisualStyleBackColor = false;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 45);
            this.label4.TabIndex = 39;
            this.label4.Text = "Facturas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 7F);
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(884, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Datos del usuario";
            // 
            // DatosEmpresa
            // 
            this.DatosEmpresa.AutoSize = true;
            this.DatosEmpresa.Font = new System.Drawing.Font("Microsoft YaHei", 7F);
            this.DatosEmpresa.ForeColor = System.Drawing.SystemColors.GrayText;
            this.DatosEmpresa.Location = new System.Drawing.Point(625, 19);
            this.DatosEmpresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DatosEmpresa.Name = "DatosEmpresa";
            this.DatosEmpresa.Size = new System.Drawing.Size(130, 17);
            this.DatosEmpresa.TabIndex = 35;
            this.DatosEmpresa.Text = "Datos de la Empresa";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Parcial_N_2.Properties.Resources.user___copia;
            this.pictureBox2.Location = new System.Drawing.Point(822, 19);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::Parcial_N_2.Properties.Resources.building__1_1;
            this.pictureBox3.Location = new System.Drawing.Point(536, 19);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(54, 54);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_salir.BackgroundImage = global::Parcial_N_2.Properties.Resources.flecha_de_retorno1;
            this.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_salir.FlatAppearance.BorderSize = 0;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Location = new System.Drawing.Point(1031, 680);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(41, 34);
            this.btn_salir.TabIndex = 33;
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // listFacturaGeneral
            // 
            this.listFacturaGeneral.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listFacturaGeneral.AutoArrange = false;
            this.listFacturaGeneral.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnCodigo,
            this.columnFecha,
            this.columnCliente,
            this.columnPago,
            this.columnMonto});
            this.listFacturaGeneral.HideSelection = false;
            this.listFacturaGeneral.Location = new System.Drawing.Point(49, 216);
            this.listFacturaGeneral.Name = "listFacturaGeneral";
            this.listFacturaGeneral.Size = new System.Drawing.Size(1022, 447);
            this.listFacturaGeneral.TabIndex = 43;
            this.listFacturaGeneral.UseCompatibleStateImageBehavior = false;
            this.listFacturaGeneral.View = System.Windows.Forms.View.Details;
            this.listFacturaGeneral.SelectedIndexChanged += new System.EventHandler(this.listFacturaGeneral_SelectedIndexChanged);
            // 
            // columnCodigo
            // 
            this.columnCodigo.Text = "Codigo";
            this.columnCodigo.Width = 120;
            // 
            // columnFecha
            // 
            this.columnFecha.Text = "Fecha";
            this.columnFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnFecha.Width = 120;
            // 
            // columnCliente
            // 
            this.columnCliente.Text = "Cliente";
            this.columnCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnCliente.Width = 120;
            // 
            // columnPago
            // 
            this.columnPago.Text = "Metodo de Pago";
            this.columnPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnPago.Width = 120;
            // 
            // columnMonto
            // 
            this.columnMonto.Text = "Monto";
            this.columnMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnMonto.Width = 120;
            // 
            // rbAscendente
            // 
            this.rbAscendente.AutoSize = true;
            this.rbAscendente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAscendente.Location = new System.Drawing.Point(49, 190);
            this.rbAscendente.Name = "rbAscendente";
            this.rbAscendente.Size = new System.Drawing.Size(110, 20);
            this.rbAscendente.TabIndex = 44;
            this.rbAscendente.TabStop = true;
            this.rbAscendente.Text = "Ascendente";
            this.rbAscendente.UseVisualStyleBackColor = true;
            this.rbAscendente.CheckedChanged += new System.EventHandler(this.rbAscendente_CheckedChanged);
            // 
            // rbDescendente
            // 
            this.rbDescendente.AutoSize = true;
            this.rbDescendente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDescendente.Location = new System.Drawing.Point(172, 190);
            this.rbDescendente.Name = "rbDescendente";
            this.rbDescendente.Size = new System.Drawing.Size(120, 20);
            this.rbDescendente.TabIndex = 45;
            this.rbDescendente.TabStop = true;
            this.rbDescendente.Text = "Descendente";
            this.rbDescendente.UseVisualStyleBackColor = true;
            this.rbDescendente.CheckedChanged += new System.EventHandler(this.rbDescendente_CheckedChanged);
            // 
            // facturasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1115, 766);
            this.ControlBox = false;
            this.Controls.Add(this.rbDescendente);
            this.Controls.Add(this.rbAscendente);
            this.Controls.Add(this.listFacturaGeneral);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.DatosEmpresa);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btn_salir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "facturasForm";
            this.Text = "facturasForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label DatosEmpresa;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.ListView listFacturaGeneral;
        private System.Windows.Forms.ColumnHeader columnCodigo;
        private System.Windows.Forms.ColumnHeader columnFecha;
        private System.Windows.Forms.ColumnHeader columnCliente;
        private System.Windows.Forms.ColumnHeader columnPago;
        private System.Windows.Forms.ColumnHeader columnMonto;
        private System.Windows.Forms.RadioButton rbAscendente;
        private System.Windows.Forms.RadioButton rbDescendente;
    }
}