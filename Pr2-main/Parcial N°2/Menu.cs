using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_N_2
{
    public partial class Menu : Form
    {
        public static Tienda tienda = new Tienda("Tu Tienda De La Esquina", "J123456789", "tutienda@gmail.com", "0274-2638595");
        public Menu()
        {
            InitializeComponent();
            DatosEmpresa.Text = tienda.MostrarDatosTienda();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
                activeForm.Close();
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelchildForm.Controls.Add(childForm);
                panelchildForm.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            FrmAfterLogin regresarLogin = new FrmAfterLogin();
            regresarLogin.Show();
        }

        private void btn_productos_Click_1(object sender, EventArgs e)
        {
            openChildForm(new FrmProductos());
        }

        private void btn_clientes_Click_1(object sender, EventArgs e)
        {
            openChildForm(new FrmClientes());
        }

        private void btn_facturas_Click(object sender, EventArgs e)
        {
            openChildForm(new facturasForm());
        }

        private void btn_administrador_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmAdmin());

        }

        ///Home Btn


        private void btn_productos2_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmProductos());
        }

        private void btn_clientes2_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmClientes());
        }

        private void btn_facturas2_Click(object sender, EventArgs e)
        {
            openChildForm(new facturasForm());
        }

        private void administrador_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmAdmin());
        }

        private void btn_salir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
