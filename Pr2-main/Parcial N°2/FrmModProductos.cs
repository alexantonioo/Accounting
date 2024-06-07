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
    public partial class FrmModProductos : Form
    {
        public Product nuevoProducto { get; private set; }

        public FrmModProductos(Product producto)
        {
            InitializeComponent();
            textBoxNombre.Text = producto.Name;
            textBoxDescripcion.Text = producto.Description;
            textBoxCantidad.Text = producto.Stock.ToString();
            textBoxPrecio.Text = producto.Price.ToString();
   
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

        private bool ValidarProducto()
        {

            labelErrorMsg.Visible = false;
            bool noHayError = true;

            string nombreProducto = textBoxNombre.Text.Trim();
            string descripcionProducto = textBoxDescripcion.Text.Trim();
            string cantidadProducto = textBoxCantidad.Text.Trim();
            string precioProducto = textBoxPrecio.Text.Trim();


            if (string.IsNullOrEmpty(nombreProducto))
            {
                labelErrorMsg.Visible = true;
                labelErrorMsg.Text = "El campo nombre no puede estar vacio" + Environment.NewLine;
                noHayError = false;
            }
            if (string.IsNullOrEmpty(descripcionProducto))
            {
                labelErrorMsg.Visible = true;
                labelErrorMsg.Text = "El campo descripcion no puede estar vacio" + Environment.NewLine;
                noHayError = false;
            }
            if (string.IsNullOrEmpty(cantidadProducto))
            {
                labelErrorMsg.Visible = true;
                labelErrorMsg.Text = "El campo cantidad no puede estar vacio" + Environment.NewLine;
                noHayError = false;
            }
            if (string.IsNullOrEmpty(precioProducto))
            {
                labelErrorMsg.Visible = true;
                labelErrorMsg.Text = "El campo precio no puede estar vacio" + Environment.NewLine;
                noHayError = false;
            }

            int stock = Convert.ToInt32(cantidadProducto);
            double precio = Convert.ToDouble(precioProducto);

            if (precio < 0 || stock <= 0)
            {
                labelErrorMsg.Visible = true;
                labelErrorMsg.Text = "Por favor, introduce un precio o stock válido." + Environment.NewLine;
                noHayError = false;
            }

            return noHayError;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            labelErrorMsg.Visible = false;

            bool productoValido = ValidarProducto();
           
            
            string nombreProducto = textBoxNombre.Text;
            string descripcionProducto = textBoxDescripcion.Text;
            int cantidadProducto = Convert.ToInt32(textBoxCantidad.Text);
            double precioProducto = Convert.ToDouble(textBoxPrecio.Text);
            string id = Guid.NewGuid().ToString().Substring(0, 6);


            if (productoValido == true)
            {
                nuevoProducto = new Product(nombreProducto, precioProducto, cantidadProducto, descripcionProducto, id);
                // cierra el formulario una vez que agrega el empleado
                this.DialogResult = DialogResult.OK;
            }
         
        }
    }
}
