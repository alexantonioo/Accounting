namespace Parcial_N_2
{
    partial class FrmAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.Grid_Admins = new System.Windows.Forms.DataGridView();
            this.Label_Dts_User = new System.Windows.Forms.Label();
            this.DatosEmpresa = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Admin = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Admins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 45);
            this.label4.TabIndex = 40;
            this.label4.Text = "Administrador";
            // 
            // Grid_Admins
            // 
            this.Grid_Admins.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Grid_Admins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid_Admins.DefaultCellStyle = dataGridViewCellStyle1;
            this.Grid_Admins.Location = new System.Drawing.Point(39, 236);
            this.Grid_Admins.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Grid_Admins.Name = "Grid_Admins";
            this.Grid_Admins.RowHeadersWidth = 51;
            this.Grid_Admins.Size = new System.Drawing.Size(996, 372);
            this.Grid_Admins.TabIndex = 39;
            // 
            // Label_Dts_User
            // 
            this.Label_Dts_User.AutoSize = true;
            this.Label_Dts_User.Font = new System.Drawing.Font("Microsoft YaHei", 7F);
            this.Label_Dts_User.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Label_Dts_User.Location = new System.Drawing.Point(925, 37);
            this.Label_Dts_User.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Dts_User.Name = "Label_Dts_User";
            this.Label_Dts_User.Size = new System.Drawing.Size(111, 17);
            this.Label_Dts_User.TabIndex = 38;
            this.Label_Dts_User.Text = "Datos del usuario";
            this.Label_Dts_User.Click += new System.EventHandler(this.Label_Dts_User_Click);
            // 
            // DatosEmpresa
            // 
            this.DatosEmpresa.AutoSize = true;
            this.DatosEmpresa.Font = new System.Drawing.Font("Microsoft YaHei", 7F);
            this.DatosEmpresa.ForeColor = System.Drawing.SystemColors.GrayText;
            this.DatosEmpresa.Location = new System.Drawing.Point(536, 37);
            this.DatosEmpresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DatosEmpresa.Name = "DatosEmpresa";
            this.DatosEmpresa.Size = new System.Drawing.Size(130, 17);
            this.DatosEmpresa.TabIndex = 36;
            this.DatosEmpresa.Text = "Datos de la Empresa";
            this.DatosEmpresa.Click += new System.EventHandler(this.DatosEmpresa_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(912, 107);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 41);
            this.button1.TabIndex = 33;
            this.button1.Text = "Ajustes SU";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(476, -116);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 135);
            this.label1.TabIndex = 32;
            // 
            // btn_Admin
            // 
            this.btn_Admin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.btn_Admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Admin.FlatAppearance.BorderSize = 0;
            this.btn_Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Admin.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Admin.Location = new System.Drawing.Point(912, 175);
            this.btn_Admin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Admin.Name = "btn_Admin";
            this.btn_Admin.Size = new System.Drawing.Size(131, 41);
            this.btn_Admin.TabIndex = 44;
            this.btn_Admin.Text = "Ajustes Admin";
            this.btn_Admin.UseVisualStyleBackColor = false;
            this.btn_Admin.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Parcial_N_2.Properties.Resources.user___copia;
            this.pictureBox2.Location = new System.Drawing.Point(845, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::Parcial_N_2.Properties.Resources.building__1_1;
            this.pictureBox3.Location = new System.Drawing.Point(448, 15);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(54, 54);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_salir.BackgroundImage = global::Parcial_N_2.Properties.Resources.flecha_de_retorno;
            this.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_salir.FlatAppearance.BorderSize = 0;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Location = new System.Drawing.Point(1057, 716);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(41, 34);
            this.btn_salir.TabIndex = 34;
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1115, 766);
            this.Controls.Add(this.btn_Admin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Grid_Admins);
            this.Controls.Add(this.Label_Dts_User);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.DatosEmpresa);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAdmin";
            this.Text = "FrmAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Admins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView Grid_Admins;
        private System.Windows.Forms.Label Label_Dts_User;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label DatosEmpresa;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Admin;
    }
}