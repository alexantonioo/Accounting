namespace Parcial_N_2.Views
{
    partial class BuscarProducto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textNombrePro = new System.Windows.Forms.TextBox();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pCantidad = new System.Windows.Forms.Panel();
            this.bttLimpiar = new System.Windows.Forms.Button();
            this.listViewBuscarPro = new System.Windows.Forms.ListView();
            this.columnCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDescrip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRegresar = new System.Windows.Forms.Button();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.pCantidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre del Producto";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textNombrePro
            // 
            this.textNombrePro.Location = new System.Drawing.Point(227, 52);
            this.textNombrePro.Name = "textNombrePro";
            this.textNombrePro.Size = new System.Drawing.Size(160, 22);
            this.textNombrePro.TabIndex = 3;
            this.textNombrePro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(227, 80);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(160, 22);
            this.textCodigo.TabIndex = 4;
            this.textCodigo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cantidad";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(186)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(627, 313);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(106, 38);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.AgregarProducto_Click);
            // 
            // pCantidad
            // 
            this.pCantidad.AutoScroll = true;
            this.pCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.pCantidad.Controls.Add(this.nudCantidad);
            this.pCantidad.Controls.Add(this.bttLimpiar);
            this.pCantidad.Controls.Add(this.listViewBuscarPro);
            this.pCantidad.Controls.Add(this.btnRegresar);
            this.pCantidad.Controls.Add(this.btnAgregar);
            this.pCantidad.Controls.Add(this.label4);
            this.pCantidad.Controls.Add(this.textCodigo);
            this.pCantidad.Controls.Add(this.textNombrePro);
            this.pCantidad.Controls.Add(this.label3);
            this.pCantidad.Controls.Add(this.label2);
            this.pCantidad.Controls.Add(this.label1);
            this.pCantidad.Location = new System.Drawing.Point(24, 23);
            this.pCantidad.Name = "pCantidad";
            this.pCantidad.Size = new System.Drawing.Size(763, 366);
            this.pCantidad.TabIndex = 9;
            this.pCantidad.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bttLimpiar
            // 
            this.bttLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.bttLimpiar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.bttLimpiar.FlatAppearance.BorderSize = 0;
            this.bttLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bttLimpiar.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttLimpiar.Location = new System.Drawing.Point(413, 73);
            this.bttLimpiar.Name = "bttLimpiar";
            this.bttLimpiar.Size = new System.Drawing.Size(80, 35);
            this.bttLimpiar.TabIndex = 17;
            this.bttLimpiar.Text = "Limpiar";
            this.bttLimpiar.UseVisualStyleBackColor = false;
            this.bttLimpiar.Click += new System.EventHandler(this.bttLimpiar_Click);
            // 
            // listViewBuscarPro
            // 
            this.listViewBuscarPro.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnCodigo,
            this.columnCant,
            this.columnDescrip,
            this.columnPrecio});
            this.listViewBuscarPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewBuscarPro.GridLines = true;
            this.listViewBuscarPro.HideSelection = false;
            this.listViewBuscarPro.Location = new System.Drawing.Point(22, 152);
            this.listViewBuscarPro.Name = "listViewBuscarPro";
            this.listViewBuscarPro.Size = new System.Drawing.Size(711, 155);
            this.listViewBuscarPro.TabIndex = 16;
            this.listViewBuscarPro.UseCompatibleStateImageBehavior = false;
            this.listViewBuscarPro.View = System.Windows.Forms.View.Details;
            this.listViewBuscarPro.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnCodigo
            // 
            this.columnCodigo.Text = "Codigo";
            this.columnCodigo.Width = 120;
            // 
            // columnCant
            // 
            this.columnCant.Text = "Cant.";
            this.columnCant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnCant.Width = 120;
            // 
            // columnDescrip
            // 
            this.columnDescrip.Text = "Descripcion";
            this.columnDescrip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnDescrip.Width = 220;
            // 
            // columnPrecio
            // 
            this.columnPrecio.Text = "Precio";
            this.columnPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnPrecio.Width = 120;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(22, 313);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(106, 38);
            this.btnRegresar.TabIndex = 15;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.button2_Click);
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(227, 108);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(68, 22);
            this.nudCantidad.TabIndex = 18;
            this.nudCantidad.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // BuscarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(815, 415);
            this.ControlBox = false;
            this.Controls.Add(this.pCantidad);
            this.Name = "BuscarProducto";
            this.Text = "BuscarProducto";
            this.pCantidad.ResumeLayout(false);
            this.pCantidad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNombrePro;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel pCantidad;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.ListView listViewBuscarPro;
        private System.Windows.Forms.ColumnHeader columnCodigo;
        private System.Windows.Forms.ColumnHeader columnCant;
        private System.Windows.Forms.ColumnHeader columnDescrip;
        private System.Windows.Forms.ColumnHeader columnPrecio;
        private System.Windows.Forms.Button bttLimpiar;
        private System.Windows.Forms.NumericUpDown nudCantidad;
    }
}