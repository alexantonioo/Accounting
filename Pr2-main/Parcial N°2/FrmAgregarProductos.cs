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

    public partial class FrmAgregarProductos : Form
    {
        private FrmProductos _parentForm;

        public FrmAgregarProductos(FrmProductos parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Nombre del producto
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Descripción del producto
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Stock (existencias) del producto
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // Precio del producto
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string descripcion = textBox2.Text;
            string stockText = textBox3.Text;
            string precioText = textBox4.Text;
            string id = Guid.NewGuid().ToString().Substring(0, 6);

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(descripcion) || string.IsNullOrWhiteSpace(stockText) || string.IsNullOrWhiteSpace(precioText))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            int stock = Convert.ToInt32(stockText);
            double precio = Convert.ToDouble(precioText);

            if (precio <= 0 || stock <= 0)
            {
                MessageBox.Show("Por favor, introduce un precio o stock válido.");
                return;
            }


            //string name, double price, int stock, bool tax, string description, int discount, string id
            // Crear una instancia de Product

            Product nuevoProducto = new Product(nombre, precio, stock, descripcion, id);


            // Agregar el producto a la lista en "FrmProductos"

            _parentForm._productos.Add(nuevoProducto);
            // Actualizr los productos en el datagrid
            //Actualizar productos con pocas existencias

            _parentForm.ActualizarDataGridView();
            _parentForm.ActualizarProductosBajoStock();
            this.Close();
        }

        
    }
}
