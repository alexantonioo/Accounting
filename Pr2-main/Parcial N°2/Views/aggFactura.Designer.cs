namespace Parcial_N_2.Views
{
    partial class aggFactura
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
            this.buttonAggProducto = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textCedula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fechaPicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.panelNuevaFactura = new System.Windows.Forms.Panel();
            this.cbRif = new System.Windows.Forms.ComboBox();
            this.bttEliminar = new System.Windows.Forms.Button();
            this.cbDocumento = new System.Windows.Forms.ComboBox();
            this.labelMontoTtal = new System.Windows.Forms.Label();
            this.labelMontoIva = new System.Windows.Forms.Label();
            this.labelMontoSub = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelIva = new System.Windows.Forms.Label();
            this.labelSubtotal = new System.Windows.Forms.Label();
            this.listNuevaFact = new System.Windows.Forms.ListView();
            this.columnCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDescrip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPreU = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrecioTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonRegresar = new System.Windows.Forms.Button();
            this.MetodoPago = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.rbIva1 = new System.Windows.Forms.RadioButton();
            this.rbIva2 = new System.Windows.Forms.RadioButton();
            this.panelNuevaFactura.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAggProducto
            // 
            this.buttonAggProducto.BackColor = System.Drawing.Color.LightGray;
            this.buttonAggProducto.FlatAppearance.BorderColor = System.Drawing.Color.MediumBlue;
            this.buttonAggProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAggProducto.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAggProducto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAggProducto.Location = new System.Drawing.Point(616, 171);
            this.buttonAggProducto.Name = "buttonAggProducto";
            this.buttonAggProducto.Size = new System.Drawing.Size(162, 30);
            this.buttonAggProducto.TabIndex = 11;
            this.buttonAggProducto.Text = "Agregar Producto";
            this.buttonAggProducto.UseVisualStyleBackColor = false;
            this.buttonAggProducto.Click += new System.EventHandler(this.buttonAggProducto_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(186)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(805, 429);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 41);
            this.button4.TabIndex = 12;
            this.button4.Text = "Imprimir";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Imprimir);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nombre / Razon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nueva Factura";
            // 
            // textCliente
            // 
            this.textCliente.Location = new System.Drawing.Point(152, 128);
            this.textCliente.Name = "textCliente";
            this.textCliente.Size = new System.Drawing.Size(160, 22);
            this.textCliente.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "Documento";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textCedula
            // 
            this.textCedula.Location = new System.Drawing.Point(490, 99);
            this.textCedula.Name = "textCedula";
            this.textCedula.Size = new System.Drawing.Size(116, 22);
            this.textCedula.TabIndex = 4;
            this.textCedula.TextChanged += new System.EventHandler(this.textCedula_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(703, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "Telefono";
            // 
            // textTelefono
            // 
            this.textTelefono.Location = new System.Drawing.Point(779, 97);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(160, 22);
            this.textTelefono.TabIndex = 6;
            this.textTelefono.TextChanged += new System.EventHandler(this.textTelefono_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(372, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 19);
            this.label5.TabIndex = 24;
            this.label5.Text = "Numero";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // fechaPicker
            // 
            this.fechaPicker.Location = new System.Drawing.Point(685, 69);
            this.fechaPicker.Name = "fechaPicker";
            this.fechaPicker.Size = new System.Drawing.Size(254, 22);
            this.fechaPicker.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(624, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Fecha";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panelNuevaFactura
            // 
            this.panelNuevaFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.panelNuevaFactura.Controls.Add(this.rbIva2);
            this.panelNuevaFactura.Controls.Add(this.rbIva1);
            this.panelNuevaFactura.Controls.Add(this.cbRif);
            this.panelNuevaFactura.Controls.Add(this.bttEliminar);
            this.panelNuevaFactura.Controls.Add(this.cbDocumento);
            this.panelNuevaFactura.Controls.Add(this.labelMontoTtal);
            this.panelNuevaFactura.Controls.Add(this.labelMontoIva);
            this.panelNuevaFactura.Controls.Add(this.labelMontoSub);
            this.panelNuevaFactura.Controls.Add(this.labelTotal);
            this.panelNuevaFactura.Controls.Add(this.labelIva);
            this.panelNuevaFactura.Controls.Add(this.labelSubtotal);
            this.panelNuevaFactura.Controls.Add(this.listNuevaFact);
            this.panelNuevaFactura.Controls.Add(this.buttonRegresar);
            this.panelNuevaFactura.Controls.Add(this.MetodoPago);
            this.panelNuevaFactura.Controls.Add(this.label8);
            this.panelNuevaFactura.Controls.Add(this.comboBox2);
            this.panelNuevaFactura.Controls.Add(this.lblVendedor);
            this.panelNuevaFactura.Controls.Add(this.label6);
            this.panelNuevaFactura.Controls.Add(this.fechaPicker);
            this.panelNuevaFactura.Controls.Add(this.button4);
            this.panelNuevaFactura.Controls.Add(this.buttonAggProducto);
            this.panelNuevaFactura.Controls.Add(this.label5);
            this.panelNuevaFactura.Controls.Add(this.textTelefono);
            this.panelNuevaFactura.Controls.Add(this.label4);
            this.panelNuevaFactura.Controls.Add(this.textCedula);
            this.panelNuevaFactura.Controls.Add(this.label3);
            this.panelNuevaFactura.Controls.Add(this.textCliente);
            this.panelNuevaFactura.Controls.Add(this.label2);
            this.panelNuevaFactura.Controls.Add(this.label1);
            this.panelNuevaFactura.Location = new System.Drawing.Point(32, 38);
            this.panelNuevaFactura.Name = "panelNuevaFactura";
            this.panelNuevaFactura.Size = new System.Drawing.Size(992, 487);
            this.panelNuevaFactura.TabIndex = 16;
            this.panelNuevaFactura.Paint += new System.Windows.Forms.PaintEventHandler(this.panelNuevaFactura_Paint);
            // 
            // cbRif
            // 
            this.cbRif.FormattingEnabled = true;
            this.cbRif.Items.AddRange(new object[] {
            "J",
            "G",
            "V"});
            this.cbRif.Location = new System.Drawing.Point(444, 97);
            this.cbRif.Margin = new System.Windows.Forms.Padding(4);
            this.cbRif.Name = "cbRif";
            this.cbRif.Size = new System.Drawing.Size(39, 24);
            this.cbRif.TabIndex = 42;
            this.cbRif.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // bttEliminar
            // 
            this.bttEliminar.BackColor = System.Drawing.Color.LightGray;
            this.bttEliminar.FlatAppearance.BorderSize = 0;
            this.bttEliminar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bttEliminar.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttEliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bttEliminar.Location = new System.Drawing.Point(779, 171);
            this.bttEliminar.Name = "bttEliminar";
            this.bttEliminar.Size = new System.Drawing.Size(162, 30);
            this.bttEliminar.TabIndex = 41;
            this.bttEliminar.Text = "Eliminar Producto";
            this.bttEliminar.UseVisualStyleBackColor = false;
            this.bttEliminar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbDocumento
            // 
            this.cbDocumento.FormattingEnabled = true;
            this.cbDocumento.Items.AddRange(new object[] {
            "CI",
            "RIF"});
            this.cbDocumento.Location = new System.Drawing.Point(152, 94);
            this.cbDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.cbDocumento.Name = "cbDocumento";
            this.cbDocumento.Size = new System.Drawing.Size(160, 24);
            this.cbDocumento.TabIndex = 39;
            this.cbDocumento.SelectedIndexChanged += new System.EventHandler(this.cbDocumento_SelectedIndexChanged);
            // 
            // labelMontoTtal
            // 
            this.labelMontoTtal.AutoSize = true;
            this.labelMontoTtal.Location = new System.Drawing.Point(854, 399);
            this.labelMontoTtal.Name = "labelMontoTtal";
            this.labelMontoTtal.Size = new System.Drawing.Size(85, 16);
            this.labelMontoTtal.TabIndex = 36;
            this.labelMontoTtal.Text = "                          ";
            this.labelMontoTtal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelMontoIva
            // 
            this.labelMontoIva.AutoSize = true;
            this.labelMontoIva.Location = new System.Drawing.Point(854, 378);
            this.labelMontoIva.Name = "labelMontoIva";
            this.labelMontoIva.Size = new System.Drawing.Size(85, 16);
            this.labelMontoIva.TabIndex = 35;
            this.labelMontoIva.Text = "                          ";
            this.labelMontoIva.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelMontoIva.Click += new System.EventHandler(this.labelMontoIva_Click);
            // 
            // labelMontoSub
            // 
            this.labelMontoSub.AutoSize = true;
            this.labelMontoSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMontoSub.Location = new System.Drawing.Point(854, 358);
            this.labelMontoSub.Name = "labelMontoSub";
            this.labelMontoSub.Size = new System.Drawing.Size(85, 16);
            this.labelMontoSub.TabIndex = 34;
            this.labelMontoSub.Text = "                          ";
            this.labelMontoSub.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(688, 402);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(56, 16);
            this.labelTotal.TabIndex = 33;
            this.labelTotal.Text = "TOTAL";
            // 
            // labelIva
            // 
            this.labelIva.AutoSize = true;
            this.labelIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIva.Location = new System.Drawing.Point(689, 379);
            this.labelIva.Name = "labelIva";
            this.labelIva.Size = new System.Drawing.Size(31, 16);
            this.labelIva.TabIndex = 32;
            this.labelIva.Text = "IVA ";
            this.labelIva.Click += new System.EventHandler(this.labelIva_Click);
            // 
            // labelSubtotal
            // 
            this.labelSubtotal.AutoSize = true;
            this.labelSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubtotal.Location = new System.Drawing.Point(688, 358);
            this.labelSubtotal.Name = "labelSubtotal";
            this.labelSubtotal.Size = new System.Drawing.Size(83, 16);
            this.labelSubtotal.TabIndex = 31;
            this.labelSubtotal.Text = "SUB-TOTAL";
            // 
            // listNuevaFact
            // 
            this.listNuevaFact.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnCodigo,
            this.columnCant,
            this.columnDescrip,
            this.columnPreU,
            this.columnPrecioTotal});
            this.listNuevaFact.HideSelection = false;
            this.listNuevaFact.Location = new System.Drawing.Point(30, 204);
            this.listNuevaFact.Name = "listNuevaFact";
            this.listNuevaFact.Size = new System.Drawing.Size(911, 151);
            this.listNuevaFact.TabIndex = 30;
            this.listNuevaFact.UseCompatibleStateImageBehavior = false;
            this.listNuevaFact.View = System.Windows.Forms.View.Details;
            // 
            // columnCodigo
            // 
            this.columnCodigo.Text = "CODIGO";
            this.columnCodigo.Width = 79;
            // 
            // columnCant
            // 
            this.columnCant.Text = "CANT.";
            this.columnCant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnCant.Width = 110;
            // 
            // columnDescrip
            // 
            this.columnDescrip.Text = "DESCRIPCION";
            this.columnDescrip.Width = 200;
            // 
            // columnPreU
            // 
            this.columnPreU.Text = "PRECIO UNIT.";
            this.columnPreU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnPreU.Width = 136;
            // 
            // columnPrecioTotal
            // 
            this.columnPrecioTotal.Text = "PRECIO TOTAL";
            this.columnPrecioTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnPrecioTotal.Width = 131;
            // 
            // buttonRegresar
            // 
            this.buttonRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.buttonRegresar.FlatAppearance.BorderSize = 0;
            this.buttonRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegresar.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegresar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonRegresar.Location = new System.Drawing.Point(30, 429);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(134, 41);
            this.buttonRegresar.TabIndex = 28;
            this.buttonRegresar.Text = "Regresar";
            this.buttonRegresar.UseVisualStyleBackColor = false;
            this.buttonRegresar.Click += new System.EventHandler(this.buttonRegresar_Click);
            // 
            // MetodoPago
            // 
            this.MetodoPago.FormattingEnabled = true;
            this.MetodoPago.Items.AddRange(new object[] {
            "Efectivo Divisa",
            "Efectivo Bs",
            "Tarjeta de Debito",
            "Tarjeta de Credito"});
            this.MetodoPago.Location = new System.Drawing.Point(779, 128);
            this.MetodoPago.Margin = new System.Windows.Forms.Padding(4);
            this.MetodoPago.Name = "MetodoPago";
            this.MetodoPago.Size = new System.Drawing.Size(160, 24);
            this.MetodoPago.TabIndex = 27;
            this.MetodoPago.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(653, 129);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 19);
            this.label8.TabIndex = 26;
            this.label8.Text = "Metodo de Pago";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Moreno Maria",
            "Torres David",
            "Araque Leonor",
            "Prato Francicsco"});
            this.comboBox2.Location = new System.Drawing.Point(446, 125);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(160, 24);
            this.comboBox2.TabIndex = 25;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedor.Location = new System.Drawing.Point(364, 128);
            this.lblVendedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(69, 19);
            this.lblVendedor.TabIndex = 24;
            this.lblVendedor.Text = "Vendedor";
            // 
            // rbIva1
            // 
            this.rbIva1.AutoSize = true;
            this.rbIva1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbIva1.Location = new System.Drawing.Point(723, 378);
            this.rbIva1.Name = "rbIva1";
            this.rbIva1.Size = new System.Drawing.Size(49, 17);
            this.rbIva1.TabIndex = 43;
            this.rbIva1.TabStop = true;
            this.rbIva1.Text = "75%";
            this.rbIva1.UseVisualStyleBackColor = true;
            this.rbIva1.CheckedChanged += new System.EventHandler(this.rbIva1_CheckedChanged);
            // 
            // rbIva2
            // 
            this.rbIva2.AutoSize = true;
            this.rbIva2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbIva2.Location = new System.Drawing.Point(779, 378);
            this.rbIva2.Name = "rbIva2";
            this.rbIva2.Size = new System.Drawing.Size(55, 17);
            this.rbIva2.TabIndex = 44;
            this.rbIva2.TabStop = true;
            this.rbIva2.Text = "100%";
            this.rbIva2.UseVisualStyleBackColor = true;
            this.rbIva2.CheckedChanged += new System.EventHandler(this.rbIva2_CheckedChanged);
            // 
            // aggFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.ControlBox = false;
            this.Controls.Add(this.panelNuevaFactura);
            this.Name = "aggFactura";
            this.Text = "aggFactura";
            this.Load += new System.EventHandler(this.aggFactura_Load);
            this.panelNuevaFactura.ResumeLayout(false);
            this.panelNuevaFactura.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAggProducto;
        private System.Windows.Forms.Button button4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textCedula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker fechaPicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelNuevaFactura;
        private System.Windows.Forms.ComboBox MetodoPago;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Button buttonRegresar;
        private System.Windows.Forms.ListView listNuevaFact;
        private System.Windows.Forms.ColumnHeader columnCodigo;
        private System.Windows.Forms.ColumnHeader columnCant;
        private System.Windows.Forms.ColumnHeader columnDescrip;
        private System.Windows.Forms.ColumnHeader columnPreU;
        private System.Windows.Forms.ColumnHeader columnPrecioTotal;
        private System.Windows.Forms.Label labelMontoSub;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelIva;
        private System.Windows.Forms.Label labelSubtotal;
        private System.Windows.Forms.Label labelMontoTtal;
        private System.Windows.Forms.Label labelMontoIva;
        private System.Windows.Forms.ComboBox cbDocumento;
        private System.Windows.Forms.Button bttEliminar;
        private System.Windows.Forms.ComboBox cbRif;
        private System.Windows.Forms.RadioButton rbIva2;
        private System.Windows.Forms.RadioButton rbIva1;
    }
}